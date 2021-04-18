using Volo.Abp.Settings;

namespace YT.Trading.Settings
{
    public class TradingSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TradingSettings.MySetting1));
        }
    }
}
