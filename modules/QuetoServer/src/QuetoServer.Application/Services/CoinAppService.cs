using QuetoServer.Coins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace QuetoServer.Services
{
    public class CoinAppService : QuetoServerAppService, ICoinAppService
    {
        private readonly IRepository<Coin> _coinRep;
        private readonly IUnitOfWork _uow;

        public CoinAppService(IRepository<Coin> repository, IUnitOfWork uow)
        {
            _coinRep = repository;
            _uow = uow;
        }

        /// <summary>
        /// 添加币种
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CoinOutput> AddAsync(CreateCoinInput input)
        {

            var entity = ObjectMapper.Map<CreateCoinInput, Coin>(input);
            var coin = await _coinRep.InsertAsync(entity, true);
            var output = ObjectMapper.Map<Coin, CoinOutput>(coin);
            return output;

        }

        public async Task<List<CoinOutput>> GetCoinsAsync(string CoinCode)
        {
            
            var coins = _coinRep.WhereIf(!string.IsNullOrEmpty(CoinCode), o => o.CoinCode == CoinCode).ToList();
            var outputs = ObjectMapper.Map<List<Coin>, List<CoinOutput>>(coins);
            return await Task.FromResult(outputs);
        }

        /// <summary>
        /// 更新币种
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CoinOutput> UpdateCoinAsync(UpdateCoinInput input)
        {
            var entity = ObjectMapper.Map<UpdateCoinInput, Coin>(input);
            await _coinRep.UpdateAsync(entity);
            var output = ObjectMapper.Map<Coin, CoinOutput>(entity);
            return output;
        }



        public async Task UpdateCoinRateAsync(string coinCode, decimal rate)
        {
            var coin = await _coinRep.FirstOrDefaultAsync(o => o.CoinCode == coinCode);
            coin.CoinRate = rate;
            await _coinRep.UpdateAsync(coin);
        }
    }
}
