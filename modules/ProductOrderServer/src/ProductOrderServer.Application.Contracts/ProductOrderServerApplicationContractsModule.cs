using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace ProductOrderServer
{
    [DependsOn(
        typeof(ProductOrderServerDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ProductOrderServerApplicationContractsModule : AbpModule
    {

    }
}
