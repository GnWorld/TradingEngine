using Volo.Abp.Reflection;

namespace QuoteServer.Permissions
{
    public class QuoteServerPermissions
    {
        public const string GroupName = "QuoteServer";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(QuoteServerPermissions));
        }
    }
}