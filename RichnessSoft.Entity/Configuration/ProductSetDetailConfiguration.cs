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
    internal class ProductSetDetailConfiguration : IEntityTypeConfiguration<ProductSetDetail>
    {
        public void Configure(EntityTypeBuilder<ProductSetDetail> builder)
        {
            builder.ToTable("productsetdetail");
            builder.HasKey(m => m.id);
            builder.Property(e => e.settype).HasColumnType("varchar(1)");
            builder.Property(e => e.saleprice).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Company).WithMany(p => p.ProductSetDetails).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Product).WithMany(p => p.ProductSetDetails).HasForeignKey(e => e.productid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ProductSet).WithMany(p => p.ProductSetDetails).HasForeignKey(e => e.productsetid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}