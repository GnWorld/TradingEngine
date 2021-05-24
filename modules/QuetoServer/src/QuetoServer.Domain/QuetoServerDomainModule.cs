using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace QuetoServer
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(QuetoServerDomainSharedModule)
    )]
    public class QuetoServerDomainModule : AbpModule
    {

    }
}
