using Localization.Resources.AbpUi;
using QuetoServer.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace QuetoServer
{
    [DependsOn(
        typeof(QuetoServerApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class QuetoServerHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(QuetoServerHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<QuetoServerResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
