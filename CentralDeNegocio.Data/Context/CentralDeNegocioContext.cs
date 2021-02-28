using CentralDeNegocio.Data.Extensions;
using CentralDeNegocio.Data.Mappings;
using CentralDeNegocio.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CentralDeNegocio.Data.Context
{
    public class CentralDeNegocioContext : DbContext
    {
        public CentralDeNegocioContext(DbContextOptions<CentralDeNegocioContext> option)
            : base(option)
        {
        }

        #region "DBSets"

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.ApplyGlobalConfigurations();

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
