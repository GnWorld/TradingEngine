using QuetoServer.Coins;
using QuetoServer.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace QuetoServer.Services
{
    public class CoinService : QuetoServerAppService, ICoinAppService
    {
        public readonly IRepository<Coin> _coinRep;


        public CoinService(IRepository<Coin> coinRep)
        {
            _coinRep = coinRep;

        }

        public async Task AddCoinAsync(CoinDto coinDto)
        {
            var entity = coinDto.Map();
            _coinRep.InsertAsync();
        }

        public Task<CoinDto> UpdateCoinAsync()
        {
            throw new NotImplementedException();
        }
    }
}
