using Volo.Abp.Modularity;

namespace YT.Trading
{
    [DependsOn(
        typeof(TradingApplicationModule),
        typeof(TradingDomainTestModule)
        )]
    public class TradingApplicationTestModule : AbpModule
    {

    }
}