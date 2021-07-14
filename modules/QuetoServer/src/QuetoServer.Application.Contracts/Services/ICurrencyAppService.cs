using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuetoServer.Services
{
    public interface ICurrencyAppService : IApplicationService
    {

        Task<CurOutput> AddAsync(CreateCurInput input);

        Task<CurOutput> UpdateCurAsync(UpdateCurInput input);


        Task UpdateCurRateAsync(string coinCode, decimal rate);

        Task<List<CurOutput>> GetCursAsync(string CoinCode);
        //Task UpdateCoinAsync();
    }
}
