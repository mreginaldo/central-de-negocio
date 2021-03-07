using CentralDeNegocio.Data.Extensions;
using CentralDeNegocio.Data.Mappings;
using CentralDeNegocio.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CentralDeNegocio.Data.Context
{
    public class CentralDeNegocioContext : DbContext
    {
        public CentralDeNegocioContext(DbContextOptions<CentralDeNegocioContext> option) : base(option)
        {
        }

        #region "DBSets"

        public DbSet<User> User { get; set; }
        public DbSet<Client> Client { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region "Map"

            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new ClientMap());

            #endregion

            modelBuilder.ApplyGlobalConfigurations();

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}

