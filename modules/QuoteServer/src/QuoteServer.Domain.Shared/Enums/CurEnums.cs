using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteServer.Enums
{
    /// <summary>
    /// 币种类型
    /// </summary>
    public enum Cur_CurTypeEnum
    {
        /// <summary>
        /// 法币
        /// </summary>
        Legal = 0,

        /// <summary>
        /// 虚拟币
        /// </summary>
        Virtual = 1
    }


    /// <summary>
    /// 汇率模式
    /// </summary>
    public enum Cur_AnchorRateFlushEnum
    {
        /// <summary>
        /// 刷新
        /// </summary>
        Flush = 0,
        /// <summary>
        /// 固定
        /// </summary>
        Fixed = 1

    }
}
