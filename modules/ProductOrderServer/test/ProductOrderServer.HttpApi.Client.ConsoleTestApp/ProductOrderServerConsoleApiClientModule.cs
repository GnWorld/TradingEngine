using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ProductOrderServer
{
    [DependsOn(
        typeof(ProductOrderServerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ProductOrderServerConsoleApiClientModule : AbpModule
    {
        
    }
}
