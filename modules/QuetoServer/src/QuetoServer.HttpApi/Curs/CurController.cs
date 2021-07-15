
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuetoServer.Services;
using System.Threading.Tasks;
using Volo.Abp;

namespace QuetoServer.Coins
{
    [RemoteService]
    [Route("api/quetoserver/coin")]
    public class CoinController : QuetoServerController, ICurAppService
    {
        private readonly ICoinAppService _coinAppService;

        public CoinController(ICoinAppService coinAppService)
        {
            _coinAppService = coinAppService;
        }

        [HttpPost]
        [Route("addcoin")]
        public async Task<CoinOutput> AddCoinAsync(CreateCoinInput coinDto)
        {
            return await _coinAppService.AddCoinAsync(coinDto);
        }
        [HttpPost]
        [Route("updatecoin")]

        public async Task<CoinOutput> UpdateCoinAsync(UpdateCoinInput input)
        {
            return await _coinAppService.UpdateCoinAsync(input);
        }

        [HttpPost]
        [Route("updatecoinrate")]
        public async Task UpdateCoinAsync(string coinCode, decimal rate)
        {
            await _coinAppService.UpdateCoinAsync(coinCode, rate);
        }
    }
}
