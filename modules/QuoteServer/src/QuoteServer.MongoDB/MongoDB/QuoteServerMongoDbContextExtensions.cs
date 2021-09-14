using QuoteServer.Domain.Entities;
using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace QuoteServer.MongoDB
{
    public static class QuoteServerMongoDbContextExtensions
    {
        public static void ConfigureQuoteServer(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new QuoteServerMongoModelBuilderConfigurationOptions(
                QuoteServerDbProperties.DbTablePrefix
            );
            builder.Entity<Cur>(b =>
            {
                //Configure table & schema name
                b.CollectionName = QuoteServerDbProperties.DbTablePrefix + "_Currencies";
            });

            builder.Entity<Ins>(b =>
            {
                //Configure table & schema name
                b.CollectionName = QuoteServerDbProperties.DbTablePrefix + "_Instruments";
            });
            optionsAction?.Invoke(options);
        }
    }
}