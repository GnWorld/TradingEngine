using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using QuoteServer;
using AccountServer;
using ProductOrderServer;
namespace YT.Trading
{
    [DependsOn(
        typeof(TradingApplicationContractsModule),
        typeof(AbpAccountHttpApiClientModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(AbpTenantManagementHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule),
        typeof(QuoteServerHttpApiClientModule)
    )]
    [DependsOn(typeof(AccountServerHttpApiClientModule))]
    [DependsOn(typeof(ProductOrderServerHttpApiClientModule))]
    public class TradingHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(TradingApplicationContractsModule).Assembly,
                RemoteServiceName
            );
            context.Services.AddHttpClientProxies(typeof(QuoteServerApplicationContractsModule).Assembly, RemoteServiceName);
        }
    }
}
