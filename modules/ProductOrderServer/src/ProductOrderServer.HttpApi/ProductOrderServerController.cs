using ProductOrderServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductOrderServer
{
    public abstract class ProductOrderServerController : AbpController
    {
        protected ProductOrderServerController()
        {
            LocalizationResource = typeof(ProductOrderServerResource);
        }
    }
}
