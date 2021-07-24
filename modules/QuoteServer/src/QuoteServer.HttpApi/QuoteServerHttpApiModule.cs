using Localization.Resources.AbpUi;
using QuoteServer.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace QuoteServer
{
    [DependsOn(
        typeof(QuoteServerApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class QuoteServerHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(QuoteServerHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<QuoteServerResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
