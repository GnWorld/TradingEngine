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

            optionsAction?.Invoke(options);
        }
    }
}