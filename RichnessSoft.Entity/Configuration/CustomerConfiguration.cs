using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Entity.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customer");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(150)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue(ConstUtil.ACTIVE.YES).HasComment("active");
            builder.Property(e => e.custtype).HasColumnType("varchar(1)").HasDefaultValue(ConstUtil.CUSTTYPE.Individual).HasComment("I = บุคคลธรรมดา C = นิติบุคคล");
            builder.Property(e => e.status).HasColumnType("varchar(1)").HasDefaultValue("").HasComment("สถานะลูกค้า");
            builder.Property(e => e.prename).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("คำนำนหน้า");
            builder.Property(e => e.firstname).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("ชื่อ");
            builder.Property(e => e.midname).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("ชื่อกลาง่");
            builder.Property(e => e.lastname).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("นามสกุล");
            builder.Property(e => e.firstname2).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("ชื่อ");
            builder.Property(e => e.midname2).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("ชื่อกลาง่");
            builder.Property(e => e.lastname2).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("นามสกุล");
            builder.Property(e => e.sname1).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("ชื่อย่อลูกค้า");
            builder.Property(e => e.sname2).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("ชื่อย่อลูกค้า2");
            builder.Property(e => e.taxid).HasColumnType("varchar(25)").HasDefaultValue("").HasComment("เลขที่ผู้เสียภาษี");
            builder.Property(e => e.cid).HasColumnType("varchar(25)").HasDefaultValue("").HasComment("เลขที่บัตรประชาชน");
            builder.Property(e => e.cid).HasColumnType("varchar(1)").HasDefaultValue(ConstUtil.HEADOFFICE.YES).HasComment("สำนักงานใหญ่");
            builder.Property(e => e.branchcode).HasColumnType("varchar(10)").HasDefaultValue("").HasComment("รหัสสาขา");
            builder.Property(e => e.branchname).HasColumnType("varchar(255)").HasDefaultValue("").HasComment("ชื่อสาขา");
            builder.Property(e => e.teletax).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("เบอร์โทรส่ง e-tax");
            builder.Property(e => e.tel).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("เบอร์โทรศัพท์");
            builder.Property(e => e.fax).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("โทรสาร");
            builder.Property(e => e.website).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("เว็บไซต์");
            builder.Property(e => e.singlelineaddress).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("ที่อยู่บรรทัดเดียว");
            builder.Property(e => e.singlelineaddress2).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("ที่อยู่บรรทัดเดียว 2");
            builder.Property(e => e.shippingby).HasColumnType("varchar(25)").HasDefaultValue("").HasComment("จัดส่งโดย");
            builder.Property(e => e.bussinesstype).HasColumnType("varchar(255)").HasDefaultValue("").HasComment("ประเภทธุรกิจ");
            builder.Property(e => e.mopid).HasComment("วิธีการชำระเงิน");
            builder.Property(e => e.bookbankno).HasColumnType("varchar(15)").HasDefaultValue("").HasComment("เลขที่บัญชีธนาคาร");
            builder.Property(e => e.bookbankname).HasColumnType("varchar(100)").HasDefaultValue("").HasComment("ชื่อที่บัญชีธนาคาร");
            builder.Property(e => e.bankid).HasComment("ธนาคาร");
            builder.Property(e => e.bankbranch).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("สาขา");
            builder.Property(e => e.billingcond).HasColumnType("varchar(255)").HasDefaultValue("").HasComment("เงื่อนไขการวางบิล");
            builder.Property(e => e.receivingdatecond).HasColumnType("varchar(255)").HasDefaultValue("").HasComment("เงื่อนไขวันเก็บเงิน");
            builder.Property(e => e.discountendbill).HasColumnType("varchar(100)").HasDefaultValue("").HasComment("ส่วนลดท้ายบิล");
            builder.Property(e => e.discountitem).HasColumnType("varchar(100)").HasDefaultValue("").HasComment("ส่วนลดที่รายการสินเค้า");
            builder.Property(e => e.currencyid).HasComment("หน่วยเงิน");
            builder.Property(e => e.promotioncode).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("โปรโมชั่น");
            builder.Property(e => e.receivableacchartid).HasComment("รหัสบัญชีลูกหนี้การค้า");
            builder.Property(e => e.vattype).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("ประเภทภาษี");
            builder.Property(e => e.vatisout).HasColumnType("varchar(1)").HasDefaultValue(ConstUtil.VATISOUT.OUT).HasComment("แยกนอก/รวมใน");
            builder.Property(e => e.remark1).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 1");
            builder.Property(e => e.Remark2).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 2");
            builder.Property(e => e.remark3).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 3");
            builder.Property(e => e.Remark4).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 4");
            builder.Property(e => e.remark5).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 5");
            builder.Property(e => e.remark6).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 6");
            builder.Property(e => e.remark7).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 7");
            builder.Property(e => e.remark8).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 8");
            builder.Property(e => e.remark9).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 9");
            builder.Property(e => e.remark10).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("หมายเหตุ 10");
            builder.Property(e => e.memberpriceid).HasComment("ราคาสมาชิกประเภท");

            builder.Property(e => e.creditamt).HasColumnType("decimal(18, 2)").HasDefaultValue(0).HasComment("วงเงินเครดิต");
            builder.Property(e => e.creditdays).HasColumnType("decimal(18, 0)").HasDefaultValue(0).HasComment("จำนวนวันเครดิต");
            builder.Property(e => e.creditdaysbilling).HasColumnType("decimal(18, 0)").HasDefaultValue(0).HasComment("จำนวนวันเครดิต(วางบิล)");
            builder.Property(e => e.vatrate).HasColumnType("decimal(18, 2)").HasDefaultValue(0).HasComment("อัตราภาษี");


            builder.HasOne(p => p.Company).WithMany(p => p.Customers).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.CustGroup).WithMany(p => p.Customers).HasForeignKey(e => e.custgroupid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.MemberGroup).WithMany(p => p.Customers).HasForeignKey(e => e.membergroupid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Acchart).WithMany(p => p.Customers).HasForeignKey(e => e.receivableacchartid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SaleMan).WithMany(p => p.Customers).HasForeignKey(e => e.salemanid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SaleTeam).WithMany(p => p.Customers).HasForeignKey(e => e.saleteamid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SaleArea).WithMany(p => p.Customers).HasForeignKey(e => e.saleareaid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Segmentation).WithMany(p => p.Customers).HasForeignKey(e => e.segmentationid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Bank).WithMany(p => p.Customers).HasForeignKey(e => e.bankid).OnDelete(DeleteBehavior.Restrict);



        }
    }
}