using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteServer.Enums
{
    public class InstrumentEnums
    {
        /// <summary>
        /// 保证金计算模式
        /// </summary>
        public enum Ins_MarginCalcEnum
        {
            /// <summary>
            /// 正常模式，按市值和账户杠杆计算
            /// </summary>
            Normal = 0,
            /// <summary>
            /// 按照每手本币计算
            /// </summary>
            BaseCur = 1,
            /// <summary>
            /// 按照每手b或short计算
            /// </summary>
            Short = 2,
            /// <summary>
            /// 按照每手a或long计算
            /// </summary>
            Long = 3
        }

        /// <summary>
        /// 交易模式
        /// </summary>
        public enum Ins_TradeModeEnum
        {
            /// <summary>
            /// 外部行情品种
            /// </summary>
            External = 0,
            /// <summary>
            /// 只读品种
            /// </summary>
            Indictive = 1,
            /// <summary>
            /// 撮合模式
            /// </summary>
            Math = 2,
            /// <summary>
            /// 场外交易(现金、现货)
            /// </summary>
            OTC = 3,
            /// <summary>
            /// 做市
            /// </summary>
            Make = 4,
            /// <summary>
            /// 配资
            /// </summary>
            CapAlloc = 5,
            /// <summary>
            /// 做市衍生品
            /// </summary>
            MakeDerivative = 6
        }


        /// <summary>
        /// 品种状态
        /// </summary>
        public enum Ins_StatusEnum
        {
            /// <summary>
            /// 非交易时间
            /// </summary>
            Off = 0,
            /// <summary>
            /// 交易时段
            /// </summary>
            On = 1,
            /// <summary>
            /// 禁用
            /// </summary>
            Disabled = 2,
            /// <summary>
            /// 持续交易
            /// </summary>
            Sustained = 3
        }

        /// <summary>
        /// 刷新币种类型
        /// </summary>
        public enum Ins_FlushCurTypeEnum
        {
            /// <summary>
            /// 不刷新币种
            /// </summary>
            None = 0,
            /// <summary>
            /// 刷新多方币种
            /// </summary>
            FlushLong = 1,
            /// <summary>
            /// 刷新空方币种
            /// </summary>
            FlushShort = 2,
            /// <summary>
            /// 多空刷新
            /// </summary>
            Both = 3

        }

    }
}
