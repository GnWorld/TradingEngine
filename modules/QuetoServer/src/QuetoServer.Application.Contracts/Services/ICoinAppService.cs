using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuetoServer.Services
{
    public interface ICoinAppService : IApplicationService
    {

        //Task AddCoinAsync(CoinDto coinDto);
        Task AddCoinAsync(CoinDto coinDto);
        //Task UpdateCoinAsync();
    }
}
