using Volo.Abp.Modularity;

namespace ProductOrderServer
{
    [DependsOn(
        typeof(ProductOrderServerApplicationModule),
        typeof(ProductOrderServerDomainTestModule)
        )]
    public class ProductOrderServerApplicationTestModule : AbpModule
    {

    }
}
