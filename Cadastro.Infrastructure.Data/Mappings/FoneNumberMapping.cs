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
    public class FoneNumberMapping : IEntityTypeConfiguration<FoneNumberEntity>
    {
        public void Configure(EntityTypeBuilder<FoneNumberEntity> builder)
        {
            builder.ToTable("FoneNumber");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().ValueGeneratedOnAdd();

            builder.Property(x => x.ddi).IsRequired().HasColumnType("varchar(10)");

            builder.Property(x => x.ddd).IsRequired().HasColumnType("varchar(10)");

            builder.Property(x => x.number).HasColumnName("FoneNumber").IsRequired().HasColumnType("varchar(14)");

            builder.HasOne(x => x.user).WithMany(x => x.foneNumber).HasForeignKey(x => x.userId);
        }
    }
}
