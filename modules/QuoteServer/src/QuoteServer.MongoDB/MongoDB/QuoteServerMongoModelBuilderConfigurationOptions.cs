using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace QuoteServer.MongoDB
{
    public class QuoteServerMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public QuoteServerMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "QuoteServer")
            : base(collectionPrefix)
        {
        }
    }
}