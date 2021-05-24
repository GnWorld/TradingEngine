using YT.Trading.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Data;
using QuetoServer.DataSeeds;

namespace YT.Trading.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TradingEntityFrameworkCoreDbMigrationsModule),
        typeof(TradingApplicationContractsModule)
        )]
    public class TradingDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);

           
        }
    }
}
