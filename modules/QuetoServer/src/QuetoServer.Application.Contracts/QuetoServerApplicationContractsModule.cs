using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace QuetoServer
{
    [DependsOn(
        typeof(QuetoServerDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class QuetoServerApplicationContractsModule : AbpModule
    {

    }
}
