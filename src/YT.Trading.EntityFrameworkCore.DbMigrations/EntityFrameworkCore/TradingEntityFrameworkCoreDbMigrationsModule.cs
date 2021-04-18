using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace YT.Trading.EntityFrameworkCore
{
    [DependsOn(
        typeof(TradingEntityFrameworkCoreModule)
        )]
    public class TradingEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TradingMigrationsDbContext>();
        }
    }
}
