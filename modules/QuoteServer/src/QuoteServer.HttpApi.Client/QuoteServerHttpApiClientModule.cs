using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace QuoteServer
{
    [DependsOn(
        typeof(QuoteServerApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class QuoteServerHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "QuoteServer";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(QuoteServerApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
