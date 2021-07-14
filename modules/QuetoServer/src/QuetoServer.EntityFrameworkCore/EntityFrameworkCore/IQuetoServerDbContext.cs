using Microsoft.EntityFrameworkCore;
using QuetoServer.Curs;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QuetoServer.EntityFrameworkCore
{
    [ConnectionStringName(QuetoServerDbProperties.ConnectionStringName)]
    public interface IQuetoServerDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Cur> Curs { get; set; }
    }
}