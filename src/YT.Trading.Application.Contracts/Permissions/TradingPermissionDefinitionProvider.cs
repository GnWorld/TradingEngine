using YT.Trading.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace YT.Trading.Permissions
{
    public class TradingPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TradingPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(TradingPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TradingResource>(name);
        }
    }
}
