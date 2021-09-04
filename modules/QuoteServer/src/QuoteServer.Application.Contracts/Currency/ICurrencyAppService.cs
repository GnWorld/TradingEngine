using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuoteServer.Currency
{
    public interface ICurrencyAppService : IApplicationService
    {

        Task<CurOutput> AddAsync(CreateCurInput input);

        Task<CurOutput> UpdateCurAsync(UpdateCurInput input);


        Task UpdateCurRateAsync(UpdateCurRateInput input);

        Task<List<CurOutput>> GetCursAsync(string curCode = null);
        Task<CurOutput> GetCurAsync(string curCode);
    }
}
