namespace ProductOrderServer
{
    public static class ProductOrderServerDbProperties
    {
        public static string DbTablePrefix { get; set; } = "ProductOrderServer";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "ProductOrderServer";
    }
}
