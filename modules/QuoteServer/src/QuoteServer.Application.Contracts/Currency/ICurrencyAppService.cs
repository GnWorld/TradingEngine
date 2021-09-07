using QuoteServer.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuoteServer.AppService
{
    public interface ICurrencyAppService : IApplicationService
    {

        Task<CurOutput> AddAsync(CreateCurInput input);

        Task<CurOutput> UpdateCurAsync(UpdateCurInput input);


        Task UpdateCurRateAsync(UpdateCurRateInput input);

        Task<List<CurOutput>> GetCursAsync(string curCode = null);
        Task<CurOutput> GetCurByCurCodeAsync(string curCode);

        Task<CurOutput> GetCurByIdAsync(int id);

    }
}
