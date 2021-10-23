using AccountServer.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace AccountServer.Account
{
    /// <summary>
    /// 区块链钱包
    /// </summary>
    public class BlockChainWallet : Entity<Guid>
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
        ///币种Code  CurrencyCode
        /// </summary>
        public string CurCode { get; set; }

        /// <summary>
        /// 链类型
        /// </summary>
        public BlockChainTypeEnums BlockChainTypeEnum { get; set; }

        /// <summary>
        /// 区块余额
        /// </summary>
        public decimal BlockChainBalance { get; set; }

        /// <summary>
        /// 区块地址 
        /// </summary>
        public string BlockAddress { get; set; }

        /// <summary>
        /// 区块地址密钥
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// 助记词 
        /// </summary>
        public string BIP39 { get; set; }
    }
}
