using ProductOrderServer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProductOrderServer.Permissions
{
    public class ProductOrderServerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ProductOrderServerPermissions.GroupName, L("Permission:ProductOrderServer"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProductOrderServerResource>(name);
        }
    }
}