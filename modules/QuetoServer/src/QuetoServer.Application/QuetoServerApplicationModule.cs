using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.AspNetCore.Mvc;

namespace QuetoServer
{
    [DependsOn(
        typeof(QuetoServerDomainModule),
        typeof(QuetoServerApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class QuetoServerApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<QuetoServerApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<QuetoServerApplicationModule>(validate: true);
            });

            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.MinifyGeneratedScript = true;
                options.ConventionalControllers.Create(typeof(QuetoServerApplicationModule).Assembly, opts =>
                {
                    opts.RootPath = "quetoserver";
                    opts.UrlActionNameNormalizer = (action) =>
                    {
                        return action.Action.ActionName;
                    };
                });
            });
        }
    }
}
