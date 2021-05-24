using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace QuetoServer
{
    [DependsOn(
        typeof(QuetoServerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class QuetoServerConsoleApiClientModule : AbpModule
    {
        
    }
}
