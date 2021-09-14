using QuoteServer.Domain.Entities;
using QuoteServer.MongoDB;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;

namespace QuoteServer.Repositories
{
    public class MongoCurRepository : MongoDbRepository<IQuoteServerMongoDbContext, Cur, Guid>, IMongoCurRepository
    {
        public MongoCurRepository(IMongoDbContextProvider<IQuoteServerMongoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
