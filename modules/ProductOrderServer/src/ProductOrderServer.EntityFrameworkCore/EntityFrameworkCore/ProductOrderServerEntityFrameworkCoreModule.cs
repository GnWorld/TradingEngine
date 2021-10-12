using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProductOrderServer.EntityFrameworkCore
{
    [DependsOn(
        typeof(ProductOrderServerDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class ProductOrderServerEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ProductOrderServerDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}