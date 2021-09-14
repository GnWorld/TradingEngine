using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteServer.AppService.Dtos
{
    public class UpdateCurRateInput
    {
        /// <summary>
        /// 多方币种
        /// </summary>
        public string LongCur { get; set; }

        /// <summary>
        /// 空方币种
        /// </summary>
        public string ShortCur { get; set; }
        /// <summary>
        /// 刷新币种
        /// </summary>

        public string FlushCur { get; set; }
        /// <summary>
        /// 币种Code
        /// </summary>
        public string CurCode { get; set; }
        /// <summary>
        /// 汇率
        /// </summary>
        public decimal Rate { get; set; }

    }
}
