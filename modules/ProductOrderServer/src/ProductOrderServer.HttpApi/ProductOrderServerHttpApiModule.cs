using Localization.Resources.AbpUi;
using ProductOrderServer.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ProductOrderServer
{
    [DependsOn(
        typeof(ProductOrderServerApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ProductOrderServerHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ProductOrderServerHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ProductOrderServerResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
