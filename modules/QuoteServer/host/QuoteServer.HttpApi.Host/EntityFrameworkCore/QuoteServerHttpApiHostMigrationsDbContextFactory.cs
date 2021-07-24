using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QuoteServer.EntityFrameworkCore
{
    public class QuoteServerHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<QuoteServerHttpApiHostMigrationsDbContext>
    {
        public QuoteServerHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<QuoteServerHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("QuoteServer"));

            return new QuoteServerHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
