using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AccountServer
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(AccountServerDomainSharedModule)
    )]
    public class AccountServerDomainModule : AbpModule
    {

    }
}
