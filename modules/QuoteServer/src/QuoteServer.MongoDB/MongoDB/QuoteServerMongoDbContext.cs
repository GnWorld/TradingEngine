using MongoDB.Driver;
using QuoteServer.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace QuoteServer.MongoDB
{
    [ConnectionStringName(QuoteServerDbProperties.ConnectionStringName)]
    public class QuoteServerMongoDbContext : AbpMongoDbContext, IQuoteServerMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */
        public IMongoCollection<Cur> Curs => Collection<Cur>();
        public IMongoCollection<Ins> Ins => Collection<Ins>();


        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);
            modelBuilder.Entity<Cur>(b =>
            {
                b.CollectionName = "Currencies";
            });

            modelBuilder.Entity<Ins>(b =>
            {
                b.CollectionName = "Instrument";
            });
            modelBuilder.ConfigureQuoteServer();
        }
    }
}