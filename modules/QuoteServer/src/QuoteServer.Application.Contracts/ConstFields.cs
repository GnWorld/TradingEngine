using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteServer
{
    public static class ConstFields
    {
        public static string SystemUserName = Environment.UserName;

        public static List<MT4SourceModel> MT4Sourcies_Enable => MT4Sourcies.Where(o=>o.IsEnable).ToList();

        public static List<MT4SourceModel> MT4Sourcies =
            new List<MT4SourceModel>() {
                new MT4SourceModel() { MT4Name = "FXPRO", MT4Key = "2010C2441A263399B34F537D91A53AC9", IsEnable = true },
                new MT4SourceModel() { MT4Name = "EXNESS", MT4Key = "F5C18A2156882613427FB4ACF0892997", IsEnable = false },
                new MT4SourceModel() { MT4Name = "FOREX", MT4Key = "89EBB79DFDD675E1C988AFB9EAE6236C", IsEnable = false },
                new MT4SourceModel() { MT4Name = "OANDA", MT4Key = "3212703ED955F10C7534BE8497B221F4", IsEnable = false },
                new MT4SourceModel() { MT4Name = "IG", MT4Key = "C142B020C05FAD9EEC4BE1375F709241", IsEnable = false },
                new MT4SourceModel() { MT4Name = "FXTM", MT4Key = "B9AB1781CD4361C9C32CAAC85492E650", IsEnable = false }
            };

        public static string GetMT4Path(string uuid)
        {
            var path_appdata =
                System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData" +
                @"\Roaming\MetaQuotes\Terminal\" + uuid + @"\MQL4\Files";
            return path_appdata;

        }
    }


}
