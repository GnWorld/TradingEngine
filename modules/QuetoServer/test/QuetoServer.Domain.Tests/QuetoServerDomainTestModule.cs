using QuetoServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QuetoServer
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(QuetoServerEntityFrameworkCoreTestModule)
        )]
    public class QuetoServerDomainTestModule : AbpModule
    {
        
    }
}
