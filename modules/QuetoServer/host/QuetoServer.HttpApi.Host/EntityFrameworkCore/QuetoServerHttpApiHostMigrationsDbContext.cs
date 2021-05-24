using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QuetoServer.EntityFrameworkCore
{
    public class QuetoServerHttpApiHostMigrationsDbContext : AbpDbContext<QuetoServerHttpApiHostMigrationsDbContext>
    {
        public QuetoServerHttpApiHostMigrationsDbContext(DbContextOptions<QuetoServerHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureQuetoServer();
        }
    }
}
