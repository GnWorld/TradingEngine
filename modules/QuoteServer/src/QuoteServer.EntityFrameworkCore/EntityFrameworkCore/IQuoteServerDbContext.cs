using Microsoft.EntityFrameworkCore;
using QuoteServer.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
namespace QuoteServer.EntityFrameworkCore
{
    [ConnectionStringName(QuoteServerDbProperties.ConnectionStringName)]
    public interface IQuoteServerDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Cur> Curs { get; set; }

        DbSet<Ins> Ins { get; set; }
    }
}