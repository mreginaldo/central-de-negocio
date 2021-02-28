using CentralDeNegocio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CentralDeNegocio.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = Guid.Parse("7776FEC6-6253-497F-A099-7D90B86D92A2"),
                        Name = "User Default",
                        Email = "userdefault@centraldenegocio.com.br", 
                        DateCreated = new DateTime(2021, 01, 01) 
                    }
                );

            return builder;
        }
    }
}
