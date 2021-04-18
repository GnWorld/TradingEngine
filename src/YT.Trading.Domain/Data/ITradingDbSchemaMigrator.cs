using System.Threading.Tasks;

namespace YT.Trading.Data
{
    public interface ITradingDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
