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
    public class UserMapping : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().ValueGeneratedOnAdd();

            builder.Property(x => x.name).HasColumnName("Name").HasColumnType("varchar(50)");

            builder.Property(x => x.password).HasColumnName("Password").IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.confirmPassword).HasColumnName("ConfirmPassword").HasColumnType("varchar(50)");

            builder.Property(x => x.dateBirthday).HasColumnType("datetime");

            builder.HasMany(x => x.email).WithOne(x => x.user).HasForeignKey(x => x.userId);

            builder.HasMany(x => x.foneNumber).WithOne(x => x.user).HasForeignKey(x => x.userId);

            builder.HasMany(x => x.address).WithOne(x => x.user).HasForeignKey(x => x.userId);

        }
    }
}
