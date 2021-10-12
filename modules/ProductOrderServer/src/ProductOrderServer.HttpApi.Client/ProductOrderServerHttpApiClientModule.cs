using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace ProductOrderServer
{
    [DependsOn(
        typeof(ProductOrderServerApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ProductOrderServerHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "ProductOrderServer";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ProductOrderServerApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
