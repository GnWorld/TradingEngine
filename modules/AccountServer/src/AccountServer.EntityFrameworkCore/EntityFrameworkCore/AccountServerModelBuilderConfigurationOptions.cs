using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AccountServer.EntityFrameworkCore
{
    public class AccountServerModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AccountServerModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}