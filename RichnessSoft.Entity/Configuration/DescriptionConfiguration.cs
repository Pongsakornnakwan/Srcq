using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Configuration
{
    internal class DescriptionConfiguration : IEntityTypeConfiguration<Descriptions>
    {
        public void Configure(EntityTypeBuilder<Descriptions> builder)
        {
            builder.ToTable("description");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.desc).HasColumnType("varchar(500)").IsRequired();
            builder.Property(e => e.desc2).HasColumnType("varchar(500)");
            builder.Property(e=> e.dtype).HasColumnType("varchar(4)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");

            builder.HasOne(p => p.Company).WithMany(p => p.Descriptions).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}