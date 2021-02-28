using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CentralDeNegocio.Domain.Entities;
using CentralDeNegocio.Data.Mappings;
using CentralDeNegocio.Data.Extensions;

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

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
