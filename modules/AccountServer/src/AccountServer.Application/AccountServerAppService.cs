using AccountServer.Localization;
using Volo.Abp.Application.Services;

namespace AccountServer
{
    public abstract class AccountServerAppService : ApplicationService
    {
        protected AccountServerAppService()
        {
            LocalizationResource = typeof(AccountServerResource);
            ObjectMapperContext = typeof(AccountServerApplicationModule);
        }
    }
}
