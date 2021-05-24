using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace QuetoServer
{
    [DependsOn(
        typeof(QuetoServerApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class QuetoServerHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "QuetoServer";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(QuetoServerApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
