﻿using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using QuetoServer.Coins;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace QuetoServer.EntityFrameworkCore
{
    public static class QuetoServerDbContextModelCreatingExtensions
    {
        public static void ConfigureQuetoServer(
            this ModelBuilder builder,
            Action<QuetoServerModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new QuetoServerModelBuilderConfigurationOptions(
                QuetoServerDbProperties.DbTablePrefix,
                QuetoServerDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);
            
            builder.Entity<Coin>(b =>
            {
                //Configure table & schema name
                b.ToTable(QuetoServerDbProperties.DbTablePrefix + "_Coins", QuetoServerDbProperties.DbSchema);

                b.ConfigureByConvention();

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */

        }
    }
}