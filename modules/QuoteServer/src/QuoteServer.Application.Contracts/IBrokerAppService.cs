using QuoteServer.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuoteServer
{
    public interface IBrokerAppService : IApplicationService
    {
        /// <summary>
        /// 提交价格
        /// </summary>
        /// <returns></returns>
        public Task CommitPriceAsync(List<InsPriceDto> input);

        /// <summary>
        /// 提交历史
        /// </summary>
        /// <returns></returns>
        public Task CommitHistoryAsync(InsHistoryDto input);

    }
}
