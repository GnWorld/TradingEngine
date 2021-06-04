
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuetoServer.Services;
using System.Threading.Tasks;
using Volo.Abp;

namespace QuetoServer.Coins
{
    [RemoteService]
    [Route("api/QuetoServer/coin")]
    public class CoinController : QuetoServerController, ICoinAppService
    {
        private readonly ICoinAppService _coinAppService;

        public CoinController(ICoinAppService coinAppService)
        {
            _coinAppService = coinAppService;
        }

        [HttpPost]
        [Route("AddCoin")]
        public async Task<CoinOutput> AddCoinAsync(CreateCoinInput coinDto)
        {
            return await _coinAppService.AddCoinAsync(coinDto);
        }
        [HttpPost]
        [Route("UpdateCoin")]

        public async Task<CoinOutput> UpdateCoinAsync(UpdateCoinInput input)
        {
            return await _coinAppService.UpdateCoinAsync(input);
        }

        [HttpPost]
        [Route("UpdateCoinRate")]
        public Task UpdateCoinAsync(string coinCode, decimal rate)
        {
            return _coinAppService.UpdateCoinAsync(coinCode, rate);
        }
    }
}
