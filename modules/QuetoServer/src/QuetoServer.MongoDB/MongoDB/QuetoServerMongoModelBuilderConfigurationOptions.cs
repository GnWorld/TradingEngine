using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace QuetoServer.MongoDB
{
    public class QuetoServerMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public QuetoServerMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}