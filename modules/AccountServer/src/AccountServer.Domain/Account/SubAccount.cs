using System;
using System.Collections.Generic;
using System.Text;

namespace AccountServer.Account
{
    /// <summary>
    /// 多币种子账户
    /// </summary>
    public class SubAccount
    {
        /// <summary>
        /// 主账户Id
        /// </summary>
        public Guid TradeAccountId { get; set; }

        /// <summary>
        /// 拥有人
        /// </summary>
        public Guid OwnerId { get; set; }

        /// <summary>
        /// 拥有人类型 0-普通用户  1-商户 2-平台账户
        /// </summary>
        public int OwnerType { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// 冻结
        /// </summary>
        public decimal Frozen { get; set; }


    }
}
