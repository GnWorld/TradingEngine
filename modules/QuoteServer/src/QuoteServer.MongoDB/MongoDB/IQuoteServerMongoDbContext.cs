using MongoDB.Driver;
using QuoteServer.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace QuoteServer.MongoDB
{
    [ConnectionStringName(QuoteServerDbProperties.ConnectionStringName)]
    public interface IQuoteServerMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
        //IMongoCollection<Cur> Curs { get; set; }

        //IMongoCollection<Ins> Ins { get; set; }
    }

}
