using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace YT.Trading.EntityFrameworkCore
{
    public static class TradingDbContextModelCreatingExtensions
    {
        public static void ConfigureTrading(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TradingConsts.DbTablePrefix + "YourEntities", TradingConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}