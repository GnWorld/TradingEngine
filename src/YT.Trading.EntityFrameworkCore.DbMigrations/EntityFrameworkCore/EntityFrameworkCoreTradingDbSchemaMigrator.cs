using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YT.Trading.Data;
using Volo.Abp.DependencyInjection;

namespace YT.Trading.EntityFrameworkCore
{
    public class EntityFrameworkCoreTradingDbSchemaMigrator
        : ITradingDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTradingDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TradingMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TradingMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}