using Localization.Resources.AbpUi;
using YT.Trading.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;
using QuoteServer;
using ProductOrderServer;
using AccountServer;
namespace YT.Trading
{
    [DependsOn(
        typeof(TradingApplicationContractsModule),
        typeof(AbpAccountHttpApiModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpTenantManagementHttpApiModule),
        typeof(AbpFeatureManagementHttpApiModule)

        )]
    //�Զ���ģ��
    [DependsOn(typeof(QuoteServerHttpApiModule))]
    [DependsOn(typeof(ProductOrderServerHttpApiModule))]
    [DependsOn(typeof(AccountServerHttpApiModule))]
    public class TradingHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureLocalization();
        }

        private void ConfigureLocalization()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<TradingResource>()
                    .AddBaseTypes(
                        typeof(AbpUiResource)
                    );
            });
        }
    }
}
