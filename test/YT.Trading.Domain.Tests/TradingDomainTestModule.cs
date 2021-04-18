using YT.Trading.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace YT.Trading
{
    [DependsOn(
        typeof(TradingEntityFrameworkCoreTestModule)
        )]
    public class TradingDomainTestModule : AbpModule
    {

    }
}