using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace YT.Trading
{
    [Dependency(ReplaceServices = true)]
    public class TradingBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Trading";
    }
}
