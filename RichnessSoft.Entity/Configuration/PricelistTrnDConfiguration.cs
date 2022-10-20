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
    internal class PricelistTrnDConfiguration : IEntityTypeConfiguration<PricelistTrnD>
    {
        public void Configure(EntityTypeBuilder<PricelistTrnD> builder)
        {
            builder.ToTable("pricelisttrnd");
            builder.HasKey(m => m.id);
            builder.Property(e => e.qtystd).HasColumnType("decimal(18,2)");
            builder.Property(e => e.qtysale).HasColumnType("decimal(18,2)");
            builder.Property(e => e.price).HasColumnType("decimal(18,2)");
            builder.Property(e => e.discountitem).HasColumnType("varchar(100)");
            builder.Property(e => e.exp_prod_name).HasColumnType("varchar(100)");
            builder.Property(e => e.exp_stdum_per_umratio).HasColumnType("varchar(100)");

            builder.HasOne(p => p.Company).WithMany(p => p.PricelistTrnDs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Product).WithMany(p => p.PricelistTrnDs).HasForeignKey(e => e.productid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PricelistTrnH).WithMany(p => p.PricelistTrnDs).HasForeignKey(e => e.pricelisttrnhid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}