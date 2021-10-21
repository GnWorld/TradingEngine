using Localization.Resources.AbpUi;
using AccountServer.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace AccountServer
{
    [DependsOn(
        typeof(AccountServerApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class AccountServerHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AccountServerHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<AccountServerResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
