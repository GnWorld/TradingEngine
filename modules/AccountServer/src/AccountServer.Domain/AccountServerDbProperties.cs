namespace AccountServer
{
    public static class AccountServerDbProperties
    {
        public static string DbTablePrefix { get; set; } = "AccountServer";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "AccountServer";
    }
}
