using Volo.Abp.Reflection;

namespace QuetoServer.Permissions
{
    public class QuetoServerPermissions
    {
        public const string GroupName = "QuetoServer";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(QuetoServerPermissions));
        }
    }
}