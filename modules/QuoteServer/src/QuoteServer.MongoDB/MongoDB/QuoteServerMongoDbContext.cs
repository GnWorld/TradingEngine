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

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureQuoteServer();
        }
    }
}