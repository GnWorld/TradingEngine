using QuoteServer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QuoteServer.Permissions
{
    public class QuoteServerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(QuoteServerPermissions.GroupName, L("Permission:QuoteServer"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<QuoteServerResource>(name);
        }
    }
}