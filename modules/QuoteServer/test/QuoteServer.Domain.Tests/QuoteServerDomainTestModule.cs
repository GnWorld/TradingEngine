using QuoteServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QuoteServer
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(QuoteServerEntityFrameworkCoreTestModule)
        )]
    public class QuoteServerDomainTestModule : AbpModule
    {
        
    }
}
