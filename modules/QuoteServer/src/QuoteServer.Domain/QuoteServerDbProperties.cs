namespace QuoteServer
{
    public static class QuoteServerDbProperties
    {
        public static string DbTablePrefix { get; set; } = "QuoteServer";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "QuoteServer";
    }
}
