using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QuetoServer.EntityFrameworkCore
{
    public class QuetoServerHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<QuetoServerHttpApiHostMigrationsDbContext>
    {
        public QuetoServerHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<QuetoServerHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("QuetoServer"));

            return new QuetoServerHttpApiHostMigrationsDbContext(builder.Options);
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
