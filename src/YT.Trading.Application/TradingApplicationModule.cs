using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
// 自定义的模块
using QuoteServer;
using ProductOrderServer;

namespace YT.Trading
{
    [DependsOn(
        typeof(TradingDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(TradingApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(QuoteServerApplicationModule) // 行情服务模块
        )]
    [DependsOn(typeof(ProductOrderServerApplicationModule))]
    public class TradingApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<TradingApplicationModule>();
            });

        }
    }
}
