using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteServer
{

    public class MT4SourceModel
    {
        /// <summary>
        /// MT4名称
        /// </summary>
        public string MT4Name { get; set; }

        /// <summary>
        /// 路径Key值
        /// </summary>
        public string MT4Key { get; set; }

        /// <summary>
        /// 是否接入
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
