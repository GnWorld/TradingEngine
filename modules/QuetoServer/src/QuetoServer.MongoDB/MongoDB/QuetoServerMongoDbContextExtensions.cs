using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace QuetoServer.MongoDB
{
    public static class QuetoServerMongoDbContextExtensions
    {
        public static void ConfigureQuetoServer(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new QuetoServerMongoModelBuilderConfigurationOptions(
                QuetoServerDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}