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
    internal class ProductBarcodeConfiguration : IEntityTypeConfiguration<ProductBarcode>
    {
        public void Configure(EntityTypeBuilder<ProductBarcode> builder)
        {
            builder.ToTable("productbarcode");
            builder.HasKey(m => m.id);
            builder.Property(e => e.barcode).HasColumnType("varchar(100)");
            builder.Property(e => e.stdprice).HasColumnType("decimal(18,2)");
            builder.Property(e => e.memberprice1).HasColumnType("decimal(18,2)");
            builder.Property(e => e.memberprice2).HasColumnType("decimal(18,2)");
            builder.Property(e => e.memberprice3).HasColumnType("decimal(18,2)");
            builder.Property(e => e.memberprice4).HasColumnType("decimal(18,2)");
            builder.Property(e => e.memberprice5).HasColumnType("decimal(18,2)");
            builder.Property(e => e.memberprice6).HasColumnType("decimal(18,2)");
            builder.Property(e => e.memberprice7).HasColumnType("decimal(18,2)");
            builder.Property(e => e.memberprice8).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Company).WithMany(p => p.ProductBarcodes).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Product).WithMany(p => p.ProductBarcodes).HasForeignKey(e => e.productid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
