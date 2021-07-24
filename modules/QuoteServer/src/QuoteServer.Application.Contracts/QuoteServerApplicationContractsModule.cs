using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace QuoteServer
{
    [DependsOn(
        typeof(QuoteServerDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class QuoteServerApplicationContractsModule : AbpModule
    {

    }
}
