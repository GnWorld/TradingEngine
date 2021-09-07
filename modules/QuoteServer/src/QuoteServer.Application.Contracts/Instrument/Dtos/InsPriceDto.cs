using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
namespace QuoteServer.AppService.Dtos
{
    public class InsPriceDto : FullAuditedEntityDto<int>
    {
        public string Code { get; set; }
        /// <summary>
        /// 买价
        /// </summary>
        public decimal Ask { get; set; }
        /// <summary>
        /// 卖价
        /// </summary>
        public decimal Bid { get; set; }

        public long Tick { get; set; }
    }
}
