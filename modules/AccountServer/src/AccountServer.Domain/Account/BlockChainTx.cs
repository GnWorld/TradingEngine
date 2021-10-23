using AccountServer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountServer.Account
{
    /// <summary>
    /// 区块链交易记录
    /// </summary>
    public class BlockChainTx
    {

        /// <summary>
        /// 区块链钱包Id
        /// </summary>
        public Guid BlockChainWallteId { get; set; }

        /// <summary>
        /// 区块交易Id
        /// </summary>
        public string TxId { get; set; }

        /// <summary>
        /// 交易哈希
        /// </summary>
        public string BlockHash { get; set; }

        /// <summary>
        /// 链类型
        /// </summary>
        public BlockChainTypeEnums BlockChainTypeEnum { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 手续费
        /// </summary>
        public decimal Fee { get; set; }

        /// <summary>
        /// 发送地址
        /// </summary>
        public string SendAddress { get; set; }

        /// <summary>
        /// 接收地址
        /// </summary>
        public string RefAddress { get; set; }

        /// <summary>
        /// 区块时间
        /// </summary>
        public DateTime BlockTime { get; set; }

    }
}
