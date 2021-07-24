using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteServer.Currency
{
    public class UpdateCurRateInput
    {

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
