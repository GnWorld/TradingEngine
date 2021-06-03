using Microsoft.Extensions.DependencyInjection;
using QuetoServer.Coins;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using System;

namespace QuetoServer.EntityFrameworkCore
{
    [DependsOn(
        typeof(QuetoServerDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class QuetoServerEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<QuetoServerDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Coin, EfCoreRepository<QuetoServerDbContext, Coin>>();
            });
        }
    }
}