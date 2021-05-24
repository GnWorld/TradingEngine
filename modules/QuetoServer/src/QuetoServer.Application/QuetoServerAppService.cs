using QuetoServer.Localization;
using Volo.Abp.Application.Services;

namespace QuetoServer
{
    public abstract class QuetoServerAppService : ApplicationService
    {
        protected QuetoServerAppService()
        {
            LocalizationResource = typeof(QuetoServerResource);
            ObjectMapperContext = typeof(QuetoServerApplicationModule);
        }
    }
}
