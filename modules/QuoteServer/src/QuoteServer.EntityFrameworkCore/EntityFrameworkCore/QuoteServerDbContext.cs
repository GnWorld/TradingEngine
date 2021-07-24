using Microsoft.EntityFrameworkCore;
using QuoteServer.Currency;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QuoteServer.EntityFrameworkCore
{
    [ConnectionStringName(QuoteServerDbProperties.ConnectionStringName)]
    public class QuoteServerDbContext : AbpDbContext<QuoteServerDbContext>, IQuoteServerDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public QuoteServerDbContext(DbContextOptions<QuoteServerDbContext> options)
            : base(options)
        {

        }
        public DbSet<Cur> Curs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureQuoteServer();
        }
    }
}