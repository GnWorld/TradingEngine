using Volo.Abp.Modularity;

namespace QuoteServer
{
    [DependsOn(
        typeof(QuoteServerApplicationModule),
        typeof(QuoteServerDomainTestModule)
        )]
    public class QuoteServerApplicationTestModule : AbpModule
    {

    }
}
