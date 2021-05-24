using Volo.Abp.Modularity;

namespace QuetoServer
{
    [DependsOn(
        typeof(QuetoServerApplicationModule),
        typeof(QuetoServerDomainTestModule)
        )]
    public class QuetoServerApplicationTestModule : AbpModule
    {

    }
}
