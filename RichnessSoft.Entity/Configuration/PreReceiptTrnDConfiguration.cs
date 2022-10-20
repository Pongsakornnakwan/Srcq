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
    internal class PreReceiptTrnDConfiguration : IEntityTypeConfiguration<PreReceiptTrnD>
    {
        public void Configure(EntityTypeBuilder<PreReceiptTrnD> builder)
        {
            builder.ToTable("prereceipttrnd");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.docstatus).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.Seq).HasColumnType("varchar(150)");
            builder.Property(e => e.refdocheaddoctype).HasColumnType("varchar(1)");
            builder.Property(e => e.refdocitemid).HasColumnType("varchar(1)");
            builder.Property(e => e.refinvoicedocgroup).HasColumnType("varchar(1)");
            builder.Property(e => e.amount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.payamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.depositamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.whtamt).HasColumnType("decimal(18,2)");
            

            builder.HasOne(p => p.Company).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Customer).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.customerid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Vendor).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.vendorid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Contact).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.contactid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SaleMan).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.salemanid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Currency).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.currencyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PreReceiptTrnH).WithMany(p => p.PreReceiptTrnDs).HasForeignKey(e => e.prereceipttrnhid).OnDelete(DeleteBehavior.Restrict);


        }
    }
}