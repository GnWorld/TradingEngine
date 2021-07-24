using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace QuoteServer.EntityFrameworkCore
{
    public class QuoteServerModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public QuoteServerModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}