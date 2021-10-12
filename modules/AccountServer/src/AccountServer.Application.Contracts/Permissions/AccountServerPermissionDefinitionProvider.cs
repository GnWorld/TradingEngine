using AccountServer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AccountServer.Permissions
{
    public class AccountServerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AccountServerPermissions.GroupName, L("Permission:AccountServer"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AccountServerResource>(name);
        }
    }
}