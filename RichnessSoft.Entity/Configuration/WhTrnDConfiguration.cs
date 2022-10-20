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
    internal class WhTrnDConfiguration : IEntityTypeConfiguration<WhTrnD>
    {
        public void Configure(EntityTypeBuilder<WhTrnD> builder)
        {
            builder.ToTable("whtrnd");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(4)");
            builder.Property(e => e.docstatus).HasColumnType("varchar(4)");
            builder.Property(e => e.incometype).HasColumnType("varchar(25)");
            builder.Property(e => e.payamount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.taxrate).HasColumnType("decimal(18,2)");
            builder.Property(e => e.taxvalue).HasColumnType("decimal(18,2)");
            builder.Property(e => e.valueaftertax).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Company).WithMany(p => p.WhTrnDs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.WhTrnDs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.WhTrnDs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.WhTrnDs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.WhTrnDs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.WhTrnDs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.WhTrnDs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.WhTrnH).WithMany(p => p.WhTrnDs).HasForeignKey(e => e.whtrnhid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}