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
    internal class ReceiptTrnHConfiguration : IEntityTypeConfiguration<ReceiptTrnH>
    {
        public void Configure(EntityTypeBuilder<ReceiptTrnH> builder)
        {
            builder.ToTable("receipttrnh");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.doccode).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.docrefnumber).HasColumnType("varchar(150)");
            builder.Property(e => e.docstatus).HasColumnType("varchar(1)");
            builder.Property(e => e.custsuppbranchcode).HasColumnType("varchar(1)");
            builder.Property(e => e.custsupptaxid).HasColumnType("varchar(1)");
            builder.Property(e => e.addressofficedetail).HasColumnType("varchar(1)");
            builder.Property(e => e.contactname).HasColumnType("varchar(1)");
            builder.Property(e => e.contactname2).HasColumnType("varchar(1)");
            builder.Property(e => e.contacttel).HasColumnType("varchar(1)");
            builder.Property(e => e.refdoccode).HasColumnType("varchar(1)");
            builder.Property(e => e.islocked).HasColumnType("varchar(1)");
            builder.Property(e => e.currencycode).HasColumnType("varchar(1)");
            builder.Property(e => e.currencyrate).HasColumnType("decimal(18,2)");
            builder.Property(e => e.vattype).HasColumnType("varchar(1)");
            builder.Property(e => e.vatrate).HasColumnType("decimal(18,2)");
            builder.Property(e => e.vatisout).HasColumnType("varchar(1)");
            builder.Property(e => e.remark01).HasColumnType("varchar(1)");
            builder.Property(e => e.remark02).HasColumnType("varchar(1)");
            builder.Property(e => e.remark03).HasColumnType("varchar(1)");
            builder.Property(e => e.remark04).HasColumnType("varchar(1)");
            builder.Property(e => e.remark05).HasColumnType("varchar(1)");
            builder.Property(e => e.remark06).HasColumnType("varchar(1)");
            builder.Property(e => e.remark07).HasColumnType("varchar(1)");
            builder.Property(e => e.remark08).HasColumnType("varchar(1)");
            builder.Property(e => e.remark09).HasColumnType("varchar(1)");
            builder.Property(e => e.remark10).HasColumnType("varchar(1)");
            builder.Property(e => e.attach_file_01).HasColumnType("varchar(1)");
            builder.Property(e => e.attach_file_02).HasColumnType("varchar(1)");
            builder.Property(e => e.attach_file_03).HasColumnType("varchar(1)");
            builder.Property(e => e.attach_file_04).HasColumnType("varchar(1)");
            builder.Property(e => e.attach_file_05).HasColumnType("varchar(1)");


            builder.HasOne(p => p.Company).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Customer).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.customerid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Vendor).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.vendorid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Contact).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.contactid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SaleMan).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.salemanid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Currency).WithMany(p => p.ReceiptTrnHs).HasForeignKey(e => e.currencyid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}