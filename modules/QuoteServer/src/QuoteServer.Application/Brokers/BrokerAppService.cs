using QuoteServer.AppService;
using QuoteServer.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using QuoteServer.Enums;
namespace QuoteServer.Brokers
{
    public class BrokerAppService : ApplicationService, IBrokerAppService
    {
        private readonly IInsAppService _insAppService;
        private readonly ICurrencyAppService _currencyAppService;

        public BrokerAppService(IInsAppService insAppService, ICurrencyAppService currencyAppService)
        {
            _insAppService = insAppService;
            _currencyAppService = currencyAppService;
        }


        /// <summary>
        /// 提交品种价格
        /// </summary>
        /// <returns></returns>
        public async Task CommitPriceAsync(List<InsPriceDto> input)
        {
            await _insAppService.UpdateInsPriceAsync(input);
        }


        /// <summary>
        /// 提交品种行情历史
        /// </summary>
        /// <returns></returns>
        public Task CommitHistoryAsync(InsHistoryDto input)
        {
            throw new NotImplementedException();
        }
    }
}
