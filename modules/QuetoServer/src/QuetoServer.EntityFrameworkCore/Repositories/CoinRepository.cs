using QuetoServer.Coins;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using QuetoServer.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace QuetoServer.Repositories
{
    public class CoinRepository : EfCoreRepository<QuetoServerDbContext, Coin, Guid>, ICoinRepository
    {
        private readonly IDbContextProvider<QuetoServerDbContext> _dbContextProvider;
        public CoinRepository(IDbContextProvider<QuetoServerDbContext> dbContextProvider) : base(dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public Task<int> ExcuteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
