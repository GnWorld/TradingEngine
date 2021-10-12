using ProductOrderServer.Localization;
using Volo.Abp.Application.Services;

namespace ProductOrderServer
{
    public abstract class ProductOrderServerAppService : ApplicationService
    {
        protected ProductOrderServerAppService()
        {
            LocalizationResource = typeof(ProductOrderServerResource);
            ObjectMapperContext = typeof(ProductOrderServerApplicationModule);
        }
    }
}
