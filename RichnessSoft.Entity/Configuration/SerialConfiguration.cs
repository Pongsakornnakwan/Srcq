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
    internal class SerialConfiguration : IEntityTypeConfiguration<Serial>
    {
        public void Configure(EntityTypeBuilder<Serial> builder)
        {
            builder.ToTable("serial");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(100)").IsRequired();
            builder.Property(e => e.lot).HasColumnType("varchar(100)");
            builder.Property(e => e.qty).HasColumnType("decimal(18,0)");
            builder.Property(e => e.umqty).HasColumnType("decimal(18,0)");
            builder.Property(e => e.seq).HasColumnType("varchar(4)");

            builder.HasOne(p => p.Company).WithMany(p => p.Serials).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.Serials).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Product).WithMany(p => p.Serials).HasForeignKey(e => e.productid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Warehouse).WithMany(p => p.Serials).HasForeignKey(e => e.warehouseid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
