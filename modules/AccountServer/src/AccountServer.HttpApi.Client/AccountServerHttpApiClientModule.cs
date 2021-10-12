using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace AccountServer
{
    [DependsOn(
        typeof(AccountServerApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class AccountServerHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "AccountServer";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(AccountServerApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
