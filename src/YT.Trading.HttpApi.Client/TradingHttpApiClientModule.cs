using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using QuoteServer;
using ProductOrderServer;
using AccountServer;
namespace YT.Trading
{
    [DependsOn(
        typeof(TradingApplicationContractsModule),
        typeof(AbpAccountHttpApiClientModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(AbpTenantManagementHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule)

    )]
    //�Զ���ģ��
    [DependsOn(typeof(QuoteServerHttpApiClientModule))]

    [DependsOn(typeof(ProductOrderServerHttpApiClientModule))]
    [DependsOn(typeof(AccountServerHttpApiClientModule))]
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
