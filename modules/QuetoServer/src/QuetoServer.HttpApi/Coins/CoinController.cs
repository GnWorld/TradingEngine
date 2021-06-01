
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
        [Route("addcoin")]
        public async Task AddCoinAsync(CoinDto coinDto)
        {
            await _coinAppService.AddCoinAsync(coinDto);
        }
    }
}
