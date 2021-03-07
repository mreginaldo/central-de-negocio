using CentralDeNegocio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentralDeNegocio.Data.Mappings
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();

            builder
                .Property(x => x.FullName)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder
                .HasIndex(b => b.FullName);

            builder
                .Property(x => x.Email)
                .HasColumnType("varchar(250)")
                .HasMaxLength(250)
                .IsRequired();

            builder
                .HasIndex(b => b.Email)
                .IsUnique();

            builder
                .Property(x => x.PhoneNumber)
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder
                .Property(x => x.MobileNumber)
                .HasColumnType("varchar(15)")
                .HasMaxLength(15)
                .IsRequired();

            builder
                .HasIndex(b => b.MobileNumber);

            builder
                .Property(x => x.Password)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();


            //builder
            //    .HasIndex(p => new { p.Ssn, p.DateOfBirth });
        }
    }
}
