using Microsoft.Extensions.DependencyInjection;
using QuoteServer.MongoDB;
using Volo.Abp.Modularity;

namespace YT.Trading.EntityFrameworkCore
{
    [DependsOn(
        typeof(TradingEntityFrameworkCoreModule),
        typeof(QuoteServerMongoDbModule)
        )]
    public class TradingEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TradingMigrationsDbContext>();
            //context.Services.AddMongoDbContext<QuoteServerMongoDbContext>();
        }
    }
}
