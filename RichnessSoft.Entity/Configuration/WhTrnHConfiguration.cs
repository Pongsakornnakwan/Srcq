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
    internal class WhTrnHConfiguration : IEntityTypeConfiguration<WhTrnH>
    {
        public void Configure(EntityTypeBuilder<WhTrnH> builder)
        {
            builder.ToTable("whtrnh");
            builder.HasKey(m => m.id);
            builder.Property(e => e.refdoctype).HasColumnType("varchar(50)");
            builder.Property(e => e.doctype).HasColumnType("varchar(4)");
            builder.Property(e => e.doccode).HasColumnType("varchar(25)");
            builder.Property(e => e.docrefnumber).HasColumnType("varchar(30)");
            builder.Property(e => e.docstatus).HasColumnType("varchar(4)");
            builder.Property(e => e.systype).HasColumnType("varchar(4)");
            builder.Property(e => e.taxdeduction).HasColumnType("varchar(25)");
            builder.Property(e => e.whsection).HasColumnType("varchar(25)");
            builder.Property(e => e.taxseq).HasColumnType("varchar(10)");
            builder.Property(e => e.totalpayamount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.totaltaxvalue).HasColumnType("decimal(18,2)");
            builder.Property(e => e.totalvalueaftertax).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Company).WithMany(p => p.WhTrnHs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.WhTrnHs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.WhTrnHs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.WhTrnHs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.WhTrnHs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.WhTrnHs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.WhTrnHs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
        }
    }
}