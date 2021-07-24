using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QuoteServer.EntityFrameworkCore
{
    public class QuoteServerHttpApiHostMigrationsDbContext : AbpDbContext<QuoteServerHttpApiHostMigrationsDbContext>
    {
        public QuoteServerHttpApiHostMigrationsDbContext(DbContextOptions<QuoteServerHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureQuoteServer();
        }
    }
}
