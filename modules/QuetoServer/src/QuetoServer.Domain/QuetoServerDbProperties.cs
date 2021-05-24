namespace QuetoServer
{
    public static class QuetoServerDbProperties
    {
        public static string DbTablePrefix { get; set; } = "QuetoServer";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "QuetoServer";
    }
}
