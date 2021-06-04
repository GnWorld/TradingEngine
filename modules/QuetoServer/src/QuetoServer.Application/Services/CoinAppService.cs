using QuetoServer.Coins;
using System;
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
        public async Task<CoinOutput> AddCoinAsync(CreateCoinInput input)
        {
            try
            {
                var entity = ObjectMapper.Map<CreateCoinInput, Coin>(input);
                var coin = await _coinRep.InsertAsync(entity, true);
                var output = ObjectMapper.Map<Coin, CoinOutput>(coin);
                return output;
            }
            catch (Exception ex)
            {

                throw ex;
            }

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



        public async Task UpdateCoinAsync(string coinCode, decimal rate)
        {
            var coin = await _coinRep.FirstOrDefaultAsync(o => o.CoinCode == coinCode);
            coin.CoinRate = rate;
            await _coinRep.UpdateAsync(coin);
        }
    }
}
