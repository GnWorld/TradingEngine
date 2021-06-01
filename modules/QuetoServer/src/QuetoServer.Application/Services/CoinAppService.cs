﻿using QuetoServer.Coins;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace QuetoServer.Services
{
    public class CoinAppService : QuetoServerAppService, ICoinAppService
    {
        private readonly IRepository<Coin> _coinRep;
        public CoinAppService(IRepository<Coin> repository)
        {
            _coinRep = repository;
        }

        public async Task AddCoinAsync(CoinDto coinDto)
        {
            var entity = ObjectMapper.Map<CoinDto, Coin>(coinDto);
            await _coinRep.InsertAsync(entity);
        }


        //public async Task AddCoinAsync()
        //{
        //    var a = 1;
        //    var b = 1;
        //    var c = a + b;
        //    return;
        //}
    }
}
