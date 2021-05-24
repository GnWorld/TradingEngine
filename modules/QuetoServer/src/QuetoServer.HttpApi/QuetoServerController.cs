using QuetoServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QuetoServer
{
    public abstract class QuetoServerController : AbpController
    {
        protected QuetoServerController()
        {
            LocalizationResource = typeof(QuetoServerResource);
        }
    }
}
