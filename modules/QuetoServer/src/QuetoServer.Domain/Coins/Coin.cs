using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
namespace QuetoServer.Coins
{
    public class Coin : FullAuditedEntity<Guid>
    {
        public Coin()
        {
        }

        public Coin(string coinCode, decimal coinRate, string anchoringCoinCode, int decimalCount)
        {
            CoinCode = coinCode;
            CoinRate = coinRate;
            AnchoringCoinCode = anchoringCoinCode;
            DecimalCount = decimalCount;
        }

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

        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool IsDisable { get; set; }

        /// <summary>
        /// 虚拟币类型,
        /// </summary>
        public int CoinType { get; set; }

    }
}
