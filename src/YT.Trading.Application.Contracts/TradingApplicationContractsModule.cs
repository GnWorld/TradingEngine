using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using QuoteServer;
using AccountServer;
using ProductOrderServer;
namespace YT.Trading
{
    [DependsOn(
        typeof(TradingDomainSharedModule),
        typeof(AbpAccountApplicationContractsModule),
        typeof(AbpFeatureManagementApplicationContractsModule),
        typeof(AbpIdentityApplicationContractsModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(AbpTenantManagementApplicationContractsModule),
        typeof(QuoteServerApplicationContractsModule),
        typeof(AbpObjectExtendingModule)


    )]
    [DependsOn(typeof(AccountServerApplicationContractsModule))]
    [DependsOn(typeof(ProductOrderServerApplicationContractsModule))]
    public class TradingApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            TradingDtoExtensions.Configure();
        }
    }
}
