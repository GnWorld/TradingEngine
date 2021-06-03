using QuetoServer.Coins;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace QuetoServer.Services
{
    public class CoinAppService : QuetoServerAppService, ICoinAppService
    {
        private readonly IRepository<Coin> _coinRep;
        public CoinAppService(IRepository<Coin> repository)
        {
            _coinRep = repository;
        }

        public async Task AddCoinAsync(CoinDto coinDto)
        {
            try
            {
                var entity = ObjectMapper.Map<CoinDto, Coin>(coinDto);
                var a = await _coinRep.InsertAsync(entity, true);  
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        //public async Task AddCoinAsync()
        //{
        //    var a = 1;
        //    var b = 1;
        //    var c = a + b;
        //    return;
        //}
    }
}
