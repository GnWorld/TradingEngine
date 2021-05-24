using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace QuetoServer.EntityFrameworkCore
{
    public class QuetoServerModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public QuetoServerModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}