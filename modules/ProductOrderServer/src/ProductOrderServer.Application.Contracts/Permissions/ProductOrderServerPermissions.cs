using Volo.Abp.Reflection;

namespace ProductOrderServer.Permissions
{
    public class ProductOrderServerPermissions
    {
        public const string GroupName = "ProductOrderServer";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductOrderServerPermissions));
        }
    }
}