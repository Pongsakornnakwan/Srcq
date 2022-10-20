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
    internal class SerialTrnHCofiguration : IEntityTypeConfiguration<SerialTrnH>
    {
        public void Configure(EntityTypeBuilder<SerialTrnH> builder)
        {
            builder.ToTable("serialtrnh");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(4)");
            builder.Property(e => e.docstatus).HasColumnType("varchar(4)");
            builder.Property(e => e.serialcode).HasColumnType("varchar(25)");
            builder.Property(e => e.shelfcode).HasColumnType("varchar(25)");
            builder.Property(e => e.seq).HasColumnType("varchar(4)");
            
            builder.HasOne(p => p.Company).WithMany(p => p.SerialTrnHs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.SerialTrnHs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.SerialTrnHs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.SerialTrnHs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.SerialTrnHs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.SerialTrnHs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.SerialTrnHs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Product).WithMany(p => p.SerialTrnHs).HasForeignKey(e => e.productid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Warehouse).WithMany(p => p.SerialTrnHs).HasForeignKey(e => e.warehouseid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}