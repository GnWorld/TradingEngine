using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuetoServer.Services
{
    public interface ICoinAppService : IApplicationService
    {

        Task<CoinOutput> AddCoinAsync(CreateCoinInput input);

        Task<CoinOutput> UpdateCoinAsync(UpdateCoinInput input);


        Task UpdateCoinAsync(string coinCode, decimal rate);
        //Task UpdateCoinAsync();
    }
}
