using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ProductOrderServer.EntityFrameworkCore
{
    public class ProductOrderServerModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ProductOrderServerModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}