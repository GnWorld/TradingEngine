using QuoteServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QuoteServer
{
    public abstract class QuoteServerController : AbpController
    {
        protected QuoteServerController()
        {
            LocalizationResource = typeof(QuoteServerResource);
        }
    }
}
