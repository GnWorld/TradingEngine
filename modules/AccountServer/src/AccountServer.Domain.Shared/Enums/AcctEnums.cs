using System;
using System.Collections.Generic;
using System.Text;

namespace AccountServer.Enums
{
    public enum AcctTypeEnum
    {
        /// <summary>
        /// 普通账户（现金账户，类型：多币种账户,OTC买卖交易账户）
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 做市账户（类型：单币种账户）
        /// </summary>
        Make = 1,
        /// <summary>
        /// 撮合账户（类型：多币种账户）
        /// </summary>
        Match = 2,
        /// <summary>
        /// 配资账户(类型：单币种账户)
        /// </summary>
        CapAlloc = 3


    }

    public enum AcctRealDemoEnum
    {
        /// <summary>
        /// 真实账户
        /// </summary>
        Real = 0,
        /// <summary>
        /// 模拟账户
        /// </summary>
        Demo = 1

    }
    public enum AcctStatusEnum
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 冻结
        /// </summary>
        Frozen = 1,
        /// <summary>
        /// 冻结且不可查询
        /// </summary>
        FrozenInvisible = 2,

        /// <summary>
        /// 限制交易
        /// </summary>
        LimitTrade = 3

    }


}
