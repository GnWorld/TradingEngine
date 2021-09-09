using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Core
{
    /// <summary>
    /// 代码块释放耗时日志
    /// </summary>
    public class CodeWrapper : IDisposable
    {
        private string CodeKey;
        private long Since;
        public CodeWrapper(string key)
        {
            CodeKey = key;
            Since = DateTime.Now.Ticks;
        }

        public void Dispose()
        {
            Console.WriteLine($"{CodeKey}运行耗时：{new TimeSpan(DateTime.Now.Ticks - Since).TotalSeconds}秒" );
        }

        //~CodeWrapper() => this.Dispose();
    }
}
