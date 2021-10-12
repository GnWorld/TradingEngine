using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AccountServer.EntityFrameworkCore
{
    [ConnectionStringName(AccountServerDbProperties.ConnectionStringName)]
    public class AccountServerDbContext : AbpDbContext<AccountServerDbContext>, IAccountServerDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public AccountServerDbContext(DbContextOptions<AccountServerDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureAccountServer();
        }
    }
}