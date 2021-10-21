using AccountServer.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace AccountServer.Account
{
    /// <summary>
    /// 账户
    /// </summary>
    public class TradeAccount : Entity<Guid>
    {


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

        /// <summary>
        /// 币种Code
        /// </summary>
        public string CoinCode { get; set; }
        /// <summary>
        /// 账户类型
        /// </summary>
        public AcctTypeEnum AcctType { get; set; }

        /// <summary>
        /// 真实/模拟
        /// </summary>
        public AcctRealDemoEnum RealDemo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }


        public int AcctStatus { get; set; }

        /// <summary>
        /// 支付密码(MD5加密)
        /// </summary>
        public string PayPwd { get; set; }

        /// <summary>
        /// 只读密码(加密)
        /// </summary>
        public string ReadOnlyPwd { get; set; }
    }
}
