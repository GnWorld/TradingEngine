using System;
using System.Collections.Generic;
using System.Text;
using YT.Trading.Localization;
using Volo.Abp.Application.Services;

namespace YT.Trading
{
    /* Inherit your application services from this class.
     */
    public abstract class TradingAppService : ApplicationService
    {
        protected TradingAppService()
        {
            LocalizationResource = typeof(TradingResource);
        }
    }
}
