using QuetoServer.Curs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace QuetoServer.Services
{
    public class CoinAppService : QuetoServerAppService, ICurrencyAppService
    {
        private readonly IRepository<Cur> _coinRep;
        private readonly IUnitOfWork _uow;

        public CoinAppService(IRepository<Cur> repository, IUnitOfWork uow)
        {
            _coinRep = repository;
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
            var coin = await _coinRep.InsertAsync(entity, true);
            var output = ObjectMapper.Map<Cur, CurOutput>(coin);
            return output;
        }

        /// <summary>
        /// 获取币种列表
        /// </summary>
        /// <param name="curCode"></param>
        /// <returns></returns>
        public async Task<List<CurOutput>> GetCursAsync(string curCode)
        {
            var coins = _coinRep.WhereIf(!string.IsNullOrEmpty(curCode), o => o.CurCode == curCode).ToList();
            var outputs = ObjectMapper.Map<List<Cur>, List<CurOutput>>(coins);
            return await Task.FromResult(outputs);
        }

        /// <summary>
        /// 更新币种
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CurOutput> UpdateCurAsync(UpdateCurInput input)
        {
            var entity = ObjectMapper.Map<UpdateCurInput, Cur>(input);
            await _coinRep.UpdateAsync(entity);
            var output = ObjectMapper.Map<Cur, CurOutput>(entity);
            return output;
        }


        /// <summary>
        /// 更新币种汇率
        /// </summary>
        /// <param name="coinCode"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public async Task UpdateCurRateAsync(string coinCode, decimal rate)
        {
            var coin = await _coinRep.FirstOrDefaultAsync(o => o.CurCode == coinCode);
            coin.AnchorRate = rate;
            await _coinRep.UpdateAsync(coin);
        }
    }
}