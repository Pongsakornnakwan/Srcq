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
    internal class OrderTrnHCofiguration : IEntityTypeConfiguration<OrderTrnH>
    {
        public void Configure(EntityTypeBuilder<OrderTrnH> builder)
        {
            builder.ToTable("ordertrnh");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(4)");
            builder.Property(e => e.approvestatus).HasColumnType("varchar(2)");
            builder.Property(e => e.doccode).HasColumnType("varchar(25)");
            builder.Property(e => e.docrefnumber).HasColumnType("varchar(30)");
            builder.Property(e => e.docstatus).HasColumnType("varchar(4)");
            builder.Property(e => e.docisclosed).HasColumnType("varchar(2)");
            builder.Property(e => e.custaddr).HasColumnType("varchar(25)");
            builder.Property(e => e.custdeliaddr).HasColumnType("varchar(25)");
            builder.Property(e => e.custdeliaddredit).HasColumnType("varchar(500)");
            builder.Property(e => e.currencyrate).HasColumnType("decimal(18,2)");
            builder.Property(e => e.approveby).HasColumnType("varchar(25)");
            builder.Property(e => e.remark01).HasColumnType("varchar(255)");
            builder.Property(e => e.remark02).HasColumnType("varchar(255)");
            builder.Property(e => e.remark03).HasColumnType("varchar(255)");
            builder.Property(e => e.remark04).HasColumnType("varchar(255)");
            builder.Property(e => e.remark05).HasColumnType("varchar(255)");
            builder.Property(e => e.remark06).HasColumnType("varchar(255)");
            builder.Property(e => e.remark07).HasColumnType("varchar(255)");
            builder.Property(e => e.remark08).HasColumnType("varchar(255)");
            builder.Property(e => e.remark09).HasColumnType("varchar(255)");
            builder.Property(e => e.remark10).HasColumnType("varchar(255)");
            builder.Property(e => e.attach_file_01).HasColumnType("varchar(255)");
            builder.Property(e => e.attach_file_02).HasColumnType("varchar(255)");
            builder.Property(e => e.attach_file_03).HasColumnType("varchar(255)");
            builder.Property(e => e.attach_file_04).HasColumnType("varchar(255)");
            builder.Property(e => e.attach_file_05).HasColumnType("varchar(255)");
            builder.Property(e => e.sendby).HasColumnType("varchar(255)");
            builder.Property(e => e.contactname).HasColumnType("varchar(150)");
            builder.Property(e => e.vattype).HasColumnType("varchar(25)");
            builder.Property(e => e.vatrate).HasColumnType("decimal(18,2)");
            builder.Property(e => e.vatisout).HasColumnType("varchar(1)");
            builder.Property(e => e.foottotalqty).HasColumnType("decimal(18,0)");
            builder.Property(e => e.footcurramt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footstdamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footcurrdiscstr).HasColumnType("varchar(100)");
            builder.Property(e => e.footcurrdiscamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footstddiscamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footcurrafdiscamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footstdafdiscamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footcurrwithouttaxamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footstdwithouttaxamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footcurrwithtaxamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footstdwithtaxamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footcurrbfvatamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footstdbfvatamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footcurrvatamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footstdvatamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footcurrnetamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.footstdnetamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.refdoctype).HasColumnType("varchar(4)");
            builder.Property(e => e.refdoccode).HasColumnType("varchar(25)");

            builder.HasOne(p => p.Company).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Customer).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.customerid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Vendor).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.vendorid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Contact).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.contactid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SaleMan).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.salemanid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Currency).WithMany(p => p.OrderTrnHs).HasForeignKey(e => e.currencyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

