using AccountServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AccountServer
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(AccountServerEntityFrameworkCoreTestModule)
        )]
    public class AccountServerDomainTestModule : AbpModule
    {
        
    }
}
