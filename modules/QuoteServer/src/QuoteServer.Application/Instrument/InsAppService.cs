using QuoteServer.Domain.Entities;
using QuoteServer.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.Uow;
using YT.Core.TaskLib;
using QuoteServer.Enums;
using YT.Core;
using YT.Core.FileHelper;
using System.IO;

namespace QuoteServer.AppService
{
    public class InsAppService : QuoteServerAppService, IInsAppService
    {
        private readonly IRepository<Ins> _insRep;

        //private readonly IUnitOfWork _uow;
        private readonly IGuidGenerator _guidGenerator;
        private readonly TaskQueue _taskQueue;
        private readonly ICurrencyAppService _curAppService;

        public InsAppService(IRepository<Ins> insRep, IUnitOfWork uow, IGuidGenerator guidGenerator, ICurrencyAppService currencyAppService)
        {
            _taskQueue = new TaskQueue(10); // 线程队列，最大线程10
            _insRep = insRep;
            // _uow = uow;
            _guidGenerator = guidGenerator;
            _curAppService = currencyAppService;
        }

        public async Task<InsDto> AddInsAsync(InsDto input)
        {
            var entity = ObjectMapper.Map<InsDto, Ins>(input);
            var ins = await _insRep.InsertAsync(entity, true);
            var output = ObjectMapper.Map<Ins, InsDto>(ins);
            return output;
        }



        public async Task<InsDto> GetInsAsync(string Code)
        {
            var ins = await _insRep.GetAsync(o => o.Code == Code);

            var output = ObjectMapper.Map<Ins, InsDto>(ins);
            return output;
        }

        #region InsChange

        /// <summary>
        /// 更新价格
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task UpdateInsPriceAsync(List<InsPriceDto> input)
        {
            foreach (var item in input)
            {
                _taskQueue.Queue(async () => await FlushInsAsync(item));
            }
            await _taskQueue.Process();
        }
        /// <summary>
        /// 品种价格更改
        /// </summary>
        /// <param name="insPriceDto"></param>
        /// <returns></returns>
        public async Task FlushInsAsync(InsPriceDto insPriceDto)
        {
            using var cw = new CodeWrapper("FlushIns");
            var ins = await _insRep.GetAsync(o => o.Code == insPriceDto.Code);
            if (ins.EnableQuote && (ins.Ask != insPriceDto.Ask || ins.Bid != insPriceDto.Bid))
            {
                ins.Ask = insPriceDto.Ask;
                ins.Bid = insPriceDto.Bid;
                ins.LastModificationTime = DateTime.FromFileTimeUtc(insPriceDto.Tick);
                var historyPath = "D:\\InsHistory\\" + ins.Code.Replace(':', '_') + "\\" + DateTime.UtcNow.ToString("yyyy-MM-mm") + ".txt";
                FileOperation.AppendText(historyPath, ins.Ask.ToString() + ";" + ins.Bid + ";" + insPriceDto.Tick);
                await _insRep.UpdateAsync(ins, true);
            }
            var flushLong = false;
            var flushShort = false;
            switch (ins.FlushCurType)
            {
                case InstrumentEnums.Ins_FlushCurTypeEnum.FlushLong:
                    flushLong = true;
                    break;
                case InstrumentEnums.Ins_FlushCurTypeEnum.FlushShort:
                    flushShort = true;
                    break;
                case InstrumentEnums.Ins_FlushCurTypeEnum.Both:
                    flushLong = true;
                    flushShort = true;
                    break;
                default:
                    break;
            }
            if (flushLong)
            {
                await _curAppService.UpdateCurRateAsync(new UpdateCurRateInput() { LongCur = ins.LongCurCode, ShortCur = ins.ShortCurCode, FlushCur = ins.LongCurCode, Rate = (ins.Ask + ins.Bid) / 2 });
            }
            if (flushShort)
            {
                await _curAppService.UpdateCurRateAsync(new UpdateCurRateInput() { LongCur = ins.ShortCurCode, ShortCur = ins.ShortCurCode, FlushCur = ins.ShortCurCode, Rate = (ins.Ask + ins.Bid) / 2 });
            }
        }
        #endregion

    }
}
