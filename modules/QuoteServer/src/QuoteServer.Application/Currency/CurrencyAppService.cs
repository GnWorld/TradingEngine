using QuoteServer.Currency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace QuoteServer.Currency
{
    public class CurrencyAppService : QuoteServerAppService, ICurrencyAppService
    {
        private readonly IRepository<Cur> _curRep;

        private readonly IUnitOfWork _uow;

        public CurrencyAppService(IRepository<Cur> repository, IUnitOfWork uow)
        {
            _curRep = repository;
            _uow = uow;
        }

        /// <summary>
        /// 添加币种
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CurOutput> AddAsync(CreateCurInput input)
        {
            var entity = ObjectMapper.Map<CreateCurInput, Cur>(input);
            var cur = await _curRep.InsertAsync(entity, true);
            var output = ObjectMapper.Map<Cur, CurOutput>(cur);
            return output;
        }

        /// <summary>
        /// 获取币种列表
        /// </summary>
        /// <param name="curCode"></param>
        /// <returns></returns>
        public async Task<List<CurOutput>> GetCursAsync(string curCode)
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
            var cur = await _curRep.FirstOrDefaultAsync(o => o.CurCode == input.CurCode);
            cur.AnchorRate = input.Rate;
            await _curRep.UpdateAsync(cur);
        }
    }
}
