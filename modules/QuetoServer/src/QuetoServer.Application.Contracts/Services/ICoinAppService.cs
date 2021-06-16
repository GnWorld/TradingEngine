using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuetoServer.Services
{
    public interface ICoinAppService : IApplicationService
    {

        Task<CoinOutput> AddAsync(CreateCoinInput input);

        Task<CoinOutput> UpdateCoinAsync(UpdateCoinInput input);


        Task UpdateCoinRateAsync(string coinCode, decimal rate);

        Task<List<CoinOutput>> GetCoinsAsync(string CoinCode);
        //Task UpdateCoinAsync();
    }
}
