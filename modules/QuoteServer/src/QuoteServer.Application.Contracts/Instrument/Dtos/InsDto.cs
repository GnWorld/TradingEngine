using System;
using System.Collections.Generic;
using System.Text;
using static QuoteServer.Enums.InstrumentEnums;
using Volo.Abp.Application.Dtos;
namespace QuoteServer.AppService.Dtos
{
    public class InsDto : FullAuditedEntityDto<Guid>
    {
        /// <summary>
        /// 排序
        /// </summary>
        public long Sort { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 是否显示 true-显示 false-隐藏
        /// </summary>
        public bool IsShow { get; set; }
        /// <summary>
        /// 是否接入行情
        /// </summary>
        public bool EnableQuote { get; set; }
        /// <summary>
        /// 交易对编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 交易对名称
        /// </summary>
        public string AssetName { get; set; }

        /// <summary>
        /// 多方币种
        /// </summary>
        public string LongCurCode { get; set; }
        /// <summary>
        /// 空方币种
        /// </summary>
        public string ShortCurCode { get; set; }

        /// <summary>
        /// 价格转换系数   如接入BTCUSD行情，设置0.2 即缩小5倍 
        /// </summary>
        public decimal Convertor { get; set; }

        /// <summary>
        /// 最小交易单位
        /// </summary>
        public decimal MinLot { get; set; }
        /// <summary>
        /// 最小价格波动
        /// </summary>
        public decimal MinChange { get; set; }

        /// <summary>
        /// 合约规格（每手所对应的资产 以a或long计价，例如 =10000(天然气10000百万英国热量), =1000(原油1000桶), =50(恒生指数50港币X指数）
        /// </summary>
        public decimal Eta { get; set; }
        /// <summary>
        /// "A FX rate that converts <b>-denoted asset to <base_cur>-denoted asset <base_cur/b>, 按照品种的b或者short计算的资产，转换为按照本币计算资产的转换率"
        /// </summary>
        public decimal Psi { get; set; }
        /// <summary>
        /// 交易区
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 买价
        /// </summary>
        public decimal Ask { get; set; }
        /// <summary>
        /// 卖价
        /// </summary>
        public decimal Bid { get; set; }
        //public float Middle { get; set; }
        /// <summary>
        /// 固定点差
        /// </summary>
        public decimal FixedSpread { get; set; }
        /// <summary>
        /// 百分比点差
        /// </summary>
        public decimal PercentageSpread { get; set; }

        /// <summary>
        /// 外部品种行情来源商户
        /// </summary>
        public long ExtBiz { get; set; }

        /// <summary>
        /// 外部品种行情来源商户Code
        /// </summary>
        public string ExtBizCode { get; set; }

        /// <summary>
        /// 内部品种（外部品种价格变化时触发内部品种价格变动，多个中间用竖线隔开）
        /// </summary>
        public string InternalInstruments { get; set; }

        /// <summary>
        /// 刷新币种模式
        /// </summary>
        public Ins_FlushCurTypeEnum FlushCurType { get; set; }

        /// <summary>
        /// 保证金模式
        /// </summary>
        public Ins_MarginCalcEnum MarginCalc { get; set; }

        /// <summary>
        /// 初始保证金率，开仓时计算，小于初始保证金无法开仓
        /// </summary>
        public float MarginRateInit { get; set; }
        /// <summary>
        /// 维持保证金率 ，爆仓
        /// </summary>
        public float MarginRateMntn { get; set; }

        public int MarginMode { get; set; }
        /// <summary>
        /// 小数点位数
        /// </summary>
        public long DecimalCount { get; set; }
        /// <summary>
        /// 小数点位数格式化，根据DecimalCount变化，如 DecimalCount=2 则Formatter="0.00",DecimalCount=3则Formatter="0.000"
        /// </summary>
        public string Formatter { get; set; }

        /// <summary>
        /// 品种状态
        /// </summary>
        public Ins_StatusEnum Status { get; set; }

        /// <summary>
        /// 交易模式
        /// </summary>
        public Ins_TradeModeEnum TradeMode { get; set; }
    }
}
