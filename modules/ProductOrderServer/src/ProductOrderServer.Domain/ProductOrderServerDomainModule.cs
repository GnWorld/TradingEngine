using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ProductOrderServer
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ProductOrderServerDomainSharedModule)
    )]
    public class ProductOrderServerDomainModule : AbpModule
    {

    }
}
