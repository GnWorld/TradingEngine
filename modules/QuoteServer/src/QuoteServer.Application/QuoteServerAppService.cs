using QuoteServer.Localization;
using Volo.Abp.Application.Services;

namespace QuoteServer
{
    public abstract class QuoteServerAppService : ApplicationService
    {
        protected QuoteServerAppService()
        {
            LocalizationResource = typeof(QuoteServerResource);
            ObjectMapperContext = typeof(QuoteServerApplicationModule);
        }
    }
}
