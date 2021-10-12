using ProductOrderServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProductOrderServer
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ProductOrderServerEntityFrameworkCoreTestModule)
        )]
    public class ProductOrderServerDomainTestModule : AbpModule
    {
        
    }
}
