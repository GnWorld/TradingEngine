using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AccountServer.EntityFrameworkCore
{
    [ConnectionStringName(AccountServerDbProperties.ConnectionStringName)]
    public interface IAccountServerDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}