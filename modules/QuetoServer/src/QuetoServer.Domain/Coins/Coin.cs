using QuetoServer.Enums;
using System;
using Volo.Abp.Domain.Entities;
namespace QuetoServer.Coins
{
    public class Coin : Entity<Guid>
    {

        public Coin()
        {
            CreateTime = DateTime.UtcNow.Ticks;
            UpdateTime = DateTime.UtcNow.Ticks;
        }

        public Coin(string coinCode, string coinEnName, decimal coinRate, string anchoringCoinCode, int decimalCount, CoinTypeEnum coinType, string creator, long? createTime, long? updateTime, bool isDisable = false)
        {
            CoinCode = coinCode;
            CoinEnName = coinEnName ?? coinCode;
            CoinRate = coinRate;
            AnchoringCoinCode = anchoringCoinCode;
            DecimalCount = decimalCount;
            IsDisable = isDisable;
            CoinType = coinType;
            CreateTime = createTime ?? DateTime.UtcNow.Ticks;
            Creator = creator;
            UpdateTime = updateTime ?? DateTime.UtcNow.Ticks;
        }



        /// <summary>
        /// 币种编码（唯一）
        /// </summary>
        public string CoinCode { get; set; }

        /// <summary>
        /// 币种英文名称(唯一)
        /// </summary>

        public string CoinEnName { get; set; }

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
        public CoinTypeEnum CoinType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public long CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public long UpdateTime { get; set; }


    }
}
