using Microsoft.Extensions.DependencyInjection;
using QuoteServer.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QuoteServer.EntityFrameworkCore
{
    [DependsOn(
        typeof(QuoteServerDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class QuoteServerEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<QuoteServerDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddDefaultRepositories<Cur>();
                options.AddDefaultRepositories<Ins>();
                //options.AddRepository<Cur, EfCoreRepository<QuoteServerDbContext, Cur>>();
                //options.AddRepository<Ins, EfCoreRepository<QuoteServerDbContext, Ins>>();
            });
        }
    }
}