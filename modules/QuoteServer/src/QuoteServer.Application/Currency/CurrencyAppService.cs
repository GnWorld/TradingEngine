using QuoteServer.AppService.Dtos;
using QuoteServer.Domain.Entities;
using QuoteServer.Settings;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.Uow;
using YT.Core;

namespace QuoteServer.AppService
{
    public class CurrencyAppService : QuoteServerAppService, ICurrencyAppService
    {
        private readonly IRepository<Cur> _curRep;

        private readonly IUnitOfWork _uow;
        private readonly IGuidGenerator _guidGenerator;

        public CurrencyAppService(IRepository<Cur> repository, IUnitOfWork uow, IGuidGenerator guidGenerator)
        {
            _curRep = repository;
            _uow = uow;
            _guidGenerator = guidGenerator;
        }

        /// <summary>
        /// 添加币种
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CurOutput> AddAsync(CreateCurInput input)
        {
            try
            {
                var entity = ObjectMapper.Map<CreateCurInput, Cur>(input);
                var cur = await _curRep.InsertAsync(entity, true);

                var output = ObjectMapper.Map<Cur, CurOutput>(cur);
                return output;
            }
            catch (System.Exception ex)
            {

                throw;
            }

        }

        /// <summary>
        /// 获取币种列表
        /// </summary>
        /// <param name="curCode"></param>
        /// <returns></returns>
        public async Task<List<CurOutput>> GetCursAsync(string curCode = null)
        {
            var currencies =
                _curRep
                    .WhereIf(!string.IsNullOrEmpty(curCode), o => o.CurCode == curCode)
                    .ToList();
            var outputs = ObjectMapper.Map<List<Cur>, List<CurOutput>>(currencies);
            return await Task.FromResult(outputs);
        }

        /// <summary>
        /// 获取单个币种
        /// </summary>
        /// <param name="curCode"></param>
        /// <returns></returns>
        public async Task<CurOutput> GetCurAsync(string curCode)
        {
            var cur = await _curRep.FirstOrDefaultAsync(o => o.CurCode == curCode);

            return ObjectMapper.Map<Cur, CurOutput>(cur);
        }


        /// <summary>
        /// 更新币种
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CurOutput> UpdateCurAsync(UpdateCurInput input)
        {
            var cur = ObjectMapper.Map<UpdateCurInput, Cur>(input);
            await _curRep.UpdateAsync(cur);
            var output = ObjectMapper.Map<Cur, CurOutput>(cur);
            return output;
        }


        /// <summary>
        /// 更新币种汇率
        /// </summary>
        /// <param name="curCode"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public async Task UpdateCurRateAsync(UpdateCurRateInput input)
        {
            using var cw = new CodeWrapper("UpdateCurRate");
            if (input.FlushCur != QuoteServerSettings.BaseCurCode)
            {
                var cur = await _curRep.FirstOrDefaultAsync(o => (string.IsNullOrEmpty(input.CurCode) && o.CurCode == input.CurCode) || (!string.IsNullOrEmpty(input.FlushCur) && o.CurCode == input.FlushCur));
                if (cur.CurCode == input.LongCur)
                {
                    var shortCur = await _curRep.FirstOrDefaultAsync(o => o.CurCode == input.ShortCur);
                    cur.AnchorRate = shortCur.AnchorRate * input.Rate;
                }
                else
                {
                    var longCur = await _curRep.FirstOrDefaultAsync(o => o.CurCode == input.LongCur);
                    cur.AnchorRate = longCur.AnchorRate / input.Rate;
                }
                await _curRep.UpdateAsync(cur);
            }

        }
    }
}
