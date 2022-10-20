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
    internal class PriceListConfiguration : IEntityTypeConfiguration<PriceList>
    {
        public void Configure(EntityTypeBuilder<PriceList> builder)
        {
            builder.ToTable("pricelist");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(10)").IsRequired();
            builder.Property(e => e.pricelist_type).HasColumnType("varchar(1)");
            builder.Property(e => e.price).HasColumnType("decimal(18,2)");
            builder.Property(e => e.discountitem).HasColumnType("varchar(100)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");
            builder.Property(e => e.datasource).HasColumnType("varchar(50)");
            builder.Property(e => e.exp_prod_name).HasColumnType("varchar(50)");
            builder.Property(e => e.exp_stdum_per_umratio).HasColumnType("varchar(50)");

            builder.HasOne(p => p.Company).WithMany(p => p.PriceLists).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Product).WithMany(p => p.PriceLists).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}