using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace YT.Trading.Data
{
    /* This is used if database provider does't define
     * ITradingDbSchemaMigrator implementation.
     */
    public class NullTradingDbSchemaMigrator : ITradingDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}