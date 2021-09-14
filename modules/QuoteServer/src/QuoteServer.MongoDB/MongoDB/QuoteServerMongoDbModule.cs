using Microsoft.Extensions.DependencyInjection;
using QuoteServer.Domain.Entities;
using QuoteServer.Repositories;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;
using Volo.Abp.Uow;

namespace QuoteServer.MongoDB
{
    [DependsOn(
        typeof(QuoteServerDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class QuoteServerMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<QuoteServerMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
                options.AddRepository<Cur, MongoCurRepository>();
                options.AddRepository<Ins, MongoInsRepository>();
            });
            //MongoDb 事务
            Configure<AbpUnitOfWorkDefaultOptions>(options =>
            {
                options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
            });
        }
    }
}
