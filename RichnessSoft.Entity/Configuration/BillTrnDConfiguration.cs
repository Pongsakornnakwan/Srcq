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
    internal class BillTrnDConfiguration : IEntityTypeConfiguration<BillTrnD>
    {
        public void Configure(EntityTypeBuilder<BillTrnD> builder)
        {
            builder.ToTable("billtrnd");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(50)");
            builder.Property(e => e.receipttrnhid).HasColumnType("varchar(25)");
            builder.Property(e => e.docstatus).HasColumnType("varchar(50)");
            builder.Property(e => e.refinvoicelinkid).HasColumnType("varchar(100)");
            builder.Property(e => e.refinvoicedoctype).HasColumnType("varchar(100)");
            builder.Property(e => e.refinvoicedocgroup).HasColumnType("varchar(100)");
            builder.Property(e => e.amount).HasColumnType("varchar(100)");
            builder.Property(e => e.payamt).HasColumnType("varchar(100)");
            builder.Property(e => e.depositamt).HasColumnType("varchar(100)");
            builder.Property(e => e.whtamt).HasColumnType("varchar(255)");
            
            //builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            //builder.Property(e => e.name1).HasColumnType("varchar(150)").IsRequired();
            //builder.Property(e => e.name2).HasColumnType("varchar(150)");
            //builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");

            builder.HasOne(p => p.Company).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Customer).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.customerid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Vendor).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.vendorid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Contact).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.contactid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SaleMan).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.salemanid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Currency).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.currencyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.BillTrnH).WithMany(p => p.BillTrnDs).HasForeignKey(e => e.billtrnhid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}