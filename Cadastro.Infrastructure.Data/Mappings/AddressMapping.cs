using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infrastructure.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().ValueGeneratedOnAdd();

            builder.Property(x => x.street).HasColumnName("street").IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.number).HasColumnName("number").IsRequired().HasColumnType("int");

            builder.Property(x => x.complement).HasColumnName("complement").HasColumnType("varchar(30)");

            builder.Property(x => x.zipCode).HasColumnName("zipCode").IsRequired().HasColumnType("varchar(10)");

            builder.HasOne(x => x.user).WithMany(x => x.address).HasForeignKey(x => x.userId);
        }
    }
}
