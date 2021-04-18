using YT.Trading.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace YT.Trading.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TradingController : AbpController
    {
        protected TradingController()
        {
            LocalizationResource = typeof(TradingResource);
        }
    }
}