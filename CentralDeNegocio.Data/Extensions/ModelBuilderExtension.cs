﻿using CentralDeNegocio.Domain.Entities;
using CentralDeNegocio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;

namespace CentralDeNegocio.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder ApplyGlobalConfigurations(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties()) 
                { 
                    switch (property.Name) 
                    {
                        case nameof(Entity.Id):
                            property.IsKey();
                            property.IsNullable = false;
                            break;
                        case nameof(Entity.DateUpdated):
                            property.IsNullable = true;
                            break;
                        case nameof(Entity.DateCreated):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;
                        case nameof(Entity.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;
                        default:
                            break;
                    }
                }
            }

            return builder;
        }

        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Client>()
                .HasData(
                    new Client
                    {
                        Id = Guid.Parse("7776FEC6-6253-497F-A099-7D90B86D92A2"),
                        FullName = "User Default",
                        Email = "userdefault@centraldenegocio.com.br",
                        MobileNumber = "16991670698",
                        Password = "Abc123456", 
                        DateCreated = new DateTime(2021, 01, 01)
                    }
                );

            return builder;
        }
    }
}
