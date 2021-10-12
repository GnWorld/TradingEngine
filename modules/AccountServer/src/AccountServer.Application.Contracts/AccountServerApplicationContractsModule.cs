using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace AccountServer
{
    [DependsOn(
        typeof(AccountServerDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class AccountServerApplicationContractsModule : AbpModule
    {

    }
}
