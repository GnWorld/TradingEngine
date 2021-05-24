using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace QuetoServer.MongoDB
{
    [ConnectionStringName(QuetoServerDbProperties.ConnectionStringName)]
    public class QuetoServerMongoDbContext : AbpMongoDbContext, IQuetoServerMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureQuetoServer();
        }
    }
}