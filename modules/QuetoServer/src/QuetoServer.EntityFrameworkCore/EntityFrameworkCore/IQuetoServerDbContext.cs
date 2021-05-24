using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

using QuetoServer.Coins;
namespace QuetoServer.EntityFrameworkCore
{
    [ConnectionStringName(QuetoServerDbProperties.ConnectionStringName)]
    public interface IQuetoServerDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Coin> Coins { get; set; }
    }
}