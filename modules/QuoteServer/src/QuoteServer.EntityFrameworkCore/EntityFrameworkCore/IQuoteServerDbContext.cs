﻿using Microsoft.EntityFrameworkCore;
using QuoteServer.Currency;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using QuoteServer.Instrument;
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