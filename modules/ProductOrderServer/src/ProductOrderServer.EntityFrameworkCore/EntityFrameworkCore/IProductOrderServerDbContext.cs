using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ProductOrderServer.EntityFrameworkCore
{
    [ConnectionStringName(ProductOrderServerDbProperties.ConnectionStringName)]
    public interface IProductOrderServerDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}