using QuoteServer.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace QuoteServer.AppService.Dtos
{
    public class UpdateCurInput : EntityDto<Guid>
    {
        /// <summary>
        /// 币种编码（唯一）
        /// </summary>
        public string CurCode { get; set; }

        /// <summary>
        /// 币种英文名称(唯一)
        /// </summary>

        public string CurEnName { get; set; }

        /// <summary>
        /// 币种汇率
        /// </summary>
        public decimal AnchorRate { get; set; }

        /// <summary>
        /// 锚定币种Code（默认美元）
        /// </summary>
        public string AnchoringCurCode { set; get; }

        /// <summary>
        /// 汇率刷新模式
        /// </summary>
        public Cur_AnchorRateFlushEnum AnchorRateFlush { get; set; }

        /// <summary>
        /// 小数位数
        /// </summary>
        public int DecimalCount { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool IsDisable { get; set; }

        public bool IsShow { get; set; }

        /// <summary>
        /// 虚拟币类型,
        /// </summary>
        public Cur_CurTypeEnum CurType { get; set; }
    }
}
