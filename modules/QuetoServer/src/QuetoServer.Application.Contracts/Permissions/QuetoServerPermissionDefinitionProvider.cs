using QuetoServer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QuetoServer.Permissions
{
    public class QuetoServerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(QuetoServerPermissions.GroupName, L("Permission:QuetoServer"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<QuetoServerResource>(name);
        }
    }
}