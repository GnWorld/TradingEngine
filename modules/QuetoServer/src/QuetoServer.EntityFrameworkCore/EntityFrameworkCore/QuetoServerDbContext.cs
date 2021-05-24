using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QuetoServer.EntityFrameworkCore
{
    [ConnectionStringName(QuetoServerDbProperties.ConnectionStringName)]
    public class QuetoServerDbContext : AbpDbContext<QuetoServerDbContext>, IQuetoServerDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

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