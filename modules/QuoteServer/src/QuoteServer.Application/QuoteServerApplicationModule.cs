using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.AspNetCore.Mvc;
namespace QuoteServer
{
    [DependsOn(
        typeof(QuoteServerDomainModule),
        typeof(QuoteServerApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class QuoteServerApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<QuoteServerApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<QuoteServerApplicationModule>(validate: true);
            });

            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.MinifyGeneratedScript = true;
                options.ConventionalControllers.Create(typeof(QuoteServerApplicationModule).Assembly, opts =>
                {
                    opts.RootPath = "quoteserver";
                    opts.UrlActionNameNormalizer = (action) =>
                    {
                        return action.Action.ActionName;
                    };
                });
            });
        }
    }
}
