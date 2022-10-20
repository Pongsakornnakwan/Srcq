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
    internal class ProductSetConfiguration : IEntityTypeConfiguration<ProductSet>
    {
        public void Configure(EntityTypeBuilder<ProductSet> builder)
        {
            builder.ToTable("productset");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(30)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(250)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(250)");
            builder.Property(e => e.sname1).HasColumnType("varchar(250)");
            builder.Property(e => e.sname2).HasColumnType("varchar(250)");
            builder.Property(e => e.prodtype).HasColumnType("varchar(25)");
            builder.Property(e => e.setprint).HasColumnType("varchar(1)");
            builder.Property(e => e.vattype).HasColumnType("varchar(10)");
            builder.Property(e => e.remark).HasColumnType("varchar(500)");
            builder.Property(e => e.remark2).HasColumnType("varchar(500)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");

            builder.HasOne(p => p.Company).WithMany(p => p.ProductSets).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}