using CentralDeNegocio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentralDeNegocio.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.Property(x => x.Id).IsRequired();

            //builder
            //    .Property(x => x.Name)
            //    .HasColumnType("varchar(100)")
            //    .HasMaxLength(100)
            //    .IsRequired();

            //builder
            //    .HasIndex(b => b.Name);

            //builder
            //    .Property(x => x.Email)
            //    .HasColumnType("varchar(250)")
            //    .HasMaxLength(250)
            //    .IsRequired();

            //builder
            //    .HasIndex(b => b.Email)
            //    .IsUnique();

            //builder
            //    .HasIndex(p => new { p.Ssn, p.DateOfBirth });
        }
    }
}
