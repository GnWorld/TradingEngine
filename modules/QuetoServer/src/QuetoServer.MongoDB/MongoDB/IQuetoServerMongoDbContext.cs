using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace QuetoServer.MongoDB
{
    [ConnectionStringName(QuetoServerDbProperties.ConnectionStringName)]
    public interface IQuetoServerMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
