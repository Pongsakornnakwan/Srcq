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
    internal class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("vendor");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(30)").IsRequired();
            builder.Property(e => e.vendortype).HasColumnType("varchar(1)");
            builder.Property(e => e.status).HasColumnType("varchar(1)");
            builder.Property(e => e.prename).HasColumnType("varchar(30)");
            builder.Property(e => e.firstname).HasColumnType("varchar(100)");
            builder.Property(e => e.midname).HasColumnType("varchar(100)");
            builder.Property(e => e.lastname).HasColumnType("varchar(100)");
            builder.Property(e => e.firstname2).HasColumnType("varchar(100)");
            builder.Property(e => e.midname2).HasColumnType("varchar(100)");
            builder.Property(e => e.lastname2).HasColumnType("varchar(100)");
            builder.Property(e => e.name1).HasColumnType("varchar(255)");
            builder.Property(e => e.sname1).HasColumnType("varchar(255)");
            builder.Property(e => e.sname2).HasColumnType("varchar(255)");
            builder.Property(e => e.taxid).HasColumnType("varchar(25)");
            builder.Property(e => e.cid).HasColumnType("varchar(25)");
            builder.Property(e => e.headoffice).HasColumnType("varchar(1)");
            builder.Property(e => e.branchcode).HasColumnType("varchar(5)");
            builder.Property(e => e.branchname).HasColumnType("varchar(255)");
            builder.Property(e => e.teletax).HasColumnType("varchar(50)");
            builder.Property(e => e.tel).HasColumnType("varchar(50)");
            builder.Property(e => e.fax).HasColumnType("varchar(50)");
            builder.Property(e => e.website).HasColumnType("varchar(255)");
            builder.Property(e => e.singlelineaddress).HasColumnType("varchar(4000)");
            builder.Property(e => e.singlelineaddress2).HasColumnType("varchar(4000)");
            builder.Property(e => e.shippingby).HasColumnType("varchar(25)");
            builder.Property(e => e.bussinesstype).HasColumnType("varchar(255)");
            builder.Property(e => e.creditdays).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.creditamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.methodofpaymentcode).HasColumnType("varchar(50)");
            builder.Property(e => e.bookbankno).HasColumnType("varchar(15)");
            builder.Property(e => e.bookbankname).HasColumnType("varchar(100)");
            builder.Property(e => e.bankcode).HasColumnType("varchar(50)");
            builder.Property(e => e.bankbranch).HasColumnType("varchar(150)");
            builder.Property(e => e.billingcond).HasColumnType("varchar(255)");
            builder.Property(e => e.creditdays_billing).HasColumnType("varchar(100)");
            builder.Property(e => e.receivingdatecond).HasColumnType("varchar(255)");
            builder.Property(e => e.discountendbill).HasColumnType("varchar(100)");
            builder.Property(e => e.discountitem).HasColumnType("varchar(100)");
            builder.Property(e => e.currencycode).HasColumnType("varchar(50)");
            builder.Property(e => e.promotioncode).HasColumnType("varchar(50)");
            builder.Property(e => e.vattype).HasColumnType("varchar(50)");
            builder.Property(e => e.vatisout).HasColumnType("varchar(1)");
            builder.Property(e => e.remark1).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark2).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark3).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark4).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark5).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark6).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark7).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark8).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark9).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark10).HasColumnType("varchar(1000)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");

            builder.HasOne(p => p.Company).WithMany(p => p.Vendors).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.VendorGroup).WithMany(p => p.Vendors).HasForeignKey(e => e.vendorgroupid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Acchart).WithMany(p => p.Vendors).HasForeignKey(e => e.accreceivableid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
