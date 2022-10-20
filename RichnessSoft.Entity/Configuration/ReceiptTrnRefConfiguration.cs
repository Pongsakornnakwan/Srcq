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
    internal class ReceiptTrnRefConfiguration : IEntityTypeConfiguration<ReceiptTrnRef>
    {
        public void Configure(EntityTypeBuilder<ReceiptTrnRef> builder)
        {
            builder.ToTable("receipttrnref");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.docstatus).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.itemreftype).HasColumnType("varchar(150)");
            builder.Property(e => e.seq).HasColumnType("varchar(1)");
            builder.Property(e => e.rate).HasColumnType("decimal(18,2)");
            builder.Property(e => e.bfcurrvatamount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.bfstdvatamount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.vatcurramount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.vatstdamount).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Company).WithMany(p => p.ReceiptTrnRefs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.ReceiptTrnRefs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.ReceiptTrnRefs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.ReceiptTrnRefs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.ReceiptTrnRefs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.ReceiptTrnRefs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.ReceiptTrnRefs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);

        }
    }
}