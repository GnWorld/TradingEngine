using Volo.Abp.Modularity;

namespace AccountServer
{
    [DependsOn(
        typeof(AccountServerApplicationModule),
        typeof(AccountServerDomainTestModule)
        )]
    public class AccountServerApplicationTestModule : AbpModule
    {

    }
}
