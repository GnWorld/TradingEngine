using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;
using QuetoServer.Coins;
using Volo.Abp.DependencyInjection;

namespace QuetoServer.DataSeeds
{
    public class QuetoServerDataSeederContributor : IDataSeedContributor, ITransientDependency
    {

        private readonly IRepository<Coin, Guid> _coinRepository;


        public QuetoServerDataSeederContributor(IRepository<Coin, Guid> coinRepository)
        {
            _coinRepository = coinRepository;

        }

        [UnitOfWork]
        public async Task SeedAsync(DataSeedContext context)
        {
            await CreateCoins();
        }

        private async Task CreateCoins()
        {
            var coin = new Coin()
            {
                DecimalCount = 2,
                CoinCode = "USD",
                AnchoringCoinCode = "USD",
                CoinRate = 1,
                IsDeleted = false,
            };
            await _coinRepository.InsertAsync(coin);
            
        }
    }
}
