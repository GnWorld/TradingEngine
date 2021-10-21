using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AccountServer
{
    [DependsOn(
        typeof(AccountServerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AccountServerConsoleApiClientModule : AbpModule
    {
        
    }
}
