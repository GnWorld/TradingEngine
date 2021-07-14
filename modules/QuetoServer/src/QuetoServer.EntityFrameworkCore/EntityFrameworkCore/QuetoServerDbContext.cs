using Microsoft.EntityFrameworkCore;
using QuetoServer.Curs;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace QuetoServer.EntityFrameworkCore
{
    [ConnectionStringName(QuetoServerDbProperties.ConnectionStringName)]
    public class QuetoServerDbContext : AbpDbContext<QuetoServerDbContext>, IQuetoServerDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Cur> Curs { get; set; }
        public QuetoServerDbContext(DbContextOptions<QuetoServerDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureQuetoServer();
        }
    }
}