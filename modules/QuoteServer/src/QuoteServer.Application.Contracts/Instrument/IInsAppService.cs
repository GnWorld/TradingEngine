﻿using QuoteServer.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuoteServer.AppService
{
    public interface IInsAppService : IApplicationService
    {
        Task<InsDto> AddInsAsync(InsDto input);
        Task UpdateInsPriceAsync(InsPriceDto input);

        Task<InsDto> GetInsByCodeAsync(string Code);

    }


}