using System;
using System.Collections.Generic;
using System.Text;

namespace QuetoServer.Dtos
{
    public class CoinDto
    {
        public Guid? Id { get; set; }

        /// <summary>
        /// 币种编码（唯一）
        /// </summary>
        public string CoinCode { get; set; }

        /// <summary>
        /// 币种汇率
        /// </summary>
        public decimal CoinRate { get; set; }

        /// <summary>
        /// 锚定币种Code（默认美元）
        /// </summary>
        public string AnchoringCoinCode { set; get; }

        /// <summary>
        /// 小数位数
        /// </summary>
        public int DecimalCount { get; set; }

        public bool IsDisable { get; set; }
    }
}
