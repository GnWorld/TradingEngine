using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace QuoteServer
{
    [DependsOn(
        typeof(QuoteServerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class QuoteServerConsoleApiClientModule : AbpModule
    {
        
    }
}
