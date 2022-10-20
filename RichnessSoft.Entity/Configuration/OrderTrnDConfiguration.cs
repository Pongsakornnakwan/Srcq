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
    internal class OrderTrnDConfiguration : IEntityTypeConfiguration<OrderTrnD>
    {
        public void Configure(EntityTypeBuilder<OrderTrnD> builder)
        {
            builder.ToTable("ordertrnd");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(4)");
            builder.Property(e => e.type).HasColumnType("varchar(1)");
            builder.Property(e => e.prodtype).HasColumnType("varchar(25)");
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
            builder.Property(e => e.lot).HasColumnType("varchar(30)");
            builder.Property(e => e.qty).HasColumnType("decimal(18,2)");
            builder.Property(e => e.backqty).HasColumnType("decimal(18,2)");
            builder.Property(e => e.stdqty).HasColumnType("decimal(18,2)");
            builder.Property(e => e.price).HasColumnType("decimal(18,2)");
            builder.Property(e => e.discstr).HasColumnType("varchar(25)");
            builder.Property(e => e.discamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.amount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.vattype).HasColumnType("varchar(25)");
            builder.Property(e => e.vatrate).HasColumnType("decimal(18,2)");
            builder.Property(e => e.vatisout).HasColumnType("varchar(1)");
            builder.Property(e => e.parent).HasColumnType("varchar(25)");
            builder.Property(e => e.child).HasColumnType("varchar(25)");
            builder.Property(e => e.status).HasColumnType("varchar(4)");

            builder.HasOne(p => p.Company).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Customer).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.customerid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Vendor).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.vendorid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Contact).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.contactid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SaleMan).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.salemanid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Currency).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.currencyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.OrderTrnH).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.ordertrnhid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Warehouse).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.warehouseid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Product).WithMany(p => p.OrderTrnDs).HasForeignKey(e => e.productid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
