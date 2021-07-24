using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace QuoteServer
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(QuoteServerDomainSharedModule)
    )]
    public class QuoteServerDomainModule : AbpModule
    {

    }
}
