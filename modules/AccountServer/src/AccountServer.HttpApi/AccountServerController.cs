using AccountServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AccountServer
{
    public abstract class AccountServerController : AbpController
    {
        protected AccountServerController()
        {
            LocalizationResource = typeof(AccountServerResource);
        }
    }
}
