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
    internal class PricelistTrnHConfiguration : IEntityTypeConfiguration<PricelistTrnH>
    {
        public void Configure(EntityTypeBuilder<PricelistTrnH> builder)
        {
            builder.ToTable("pricelisttrnh");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.pricelisttype).HasColumnType("varchar(150)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");

            builder.HasOne(p => p.Company).WithMany(p => p.PricelistTrnHs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Customer).WithMany(p => p.PricelistTrnHs).HasForeignKey(e => e.customerid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
