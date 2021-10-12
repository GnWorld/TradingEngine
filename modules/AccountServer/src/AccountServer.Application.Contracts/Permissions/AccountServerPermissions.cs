using Volo.Abp.Reflection;

namespace AccountServer.Permissions
{
    public class AccountServerPermissions
    {
        public const string GroupName = "AccountServer";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(AccountServerPermissions));
        }
    }
}