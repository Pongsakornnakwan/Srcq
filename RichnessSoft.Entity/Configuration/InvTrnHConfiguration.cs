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
    internal class InvTrnHConfiguration : IEntityTypeConfiguration<InvTrnH>
    {
        public void Configure(EntityTypeBuilder<InvTrnH> builder)
        {
            builder.ToTable("invtrnh");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(4)").HasComment("ประเภทเอกสาร");
            builder.Property(e => e.doccode).HasColumnType("varchar(25)").IsRequired().HasComment("เลขที่เอกสารภายใน");
            builder.Property(e => e.docrefnumber).HasColumnType("varchar(30)").IsRequired().HasComment("เลขที่เอกสาร");
            builder.Property(e => e.docstatus).HasColumnType("varchar(4)").HasDefaultValue("Y").HasComment("สถานะ");
            builder.Property(e => e.custsuppbranchcode).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("สาขา ลูกค้า/ผู้จำหน่าย");
            builder.Property(e => e.custsupptax).HasColumnType("varchar(25)").HasDefaultValue("Y").HasComment("เลขประจำตัวผู้เสียภาษี ลูกค้า/ผู้จำหน่าย");
            builder.Property(e => e.addressofficeid).HasColumnType("varchar(1)").HasComment("ที่อยู่ทำงาน");
            builder.Property(e => e.addressofficedetail).HasColumnType("varchar(1000)").IsRequired().HasComment("ที่อยู่ทำงาน");
            builder.Property(e => e.addressdeliverydetail).HasColumnType("varchar(1)").HasComment("ที่อยู่ส่งของ");
            builder.Property(e => e.contacttel).HasColumnType("varchar(255)").IsRequired().HasComment("เบอร์โทรผู้ติดต่อ");
            builder.Property(e => e.shippingby).HasColumnType("varchar(25)").IsRequired().HasComment("จัดส่งโดย");
            builder.Property(e => e.purchasecode).HasColumnType("varchar(25)").IsRequired().HasComment("เลขที่สั่งซื้อ");
            builder.Property(e => e.IsRetProduct).HasColumnType("varchar(1)").IsRequired().HasComment("ต้องการคืนสินค้า / ลดจำนวนเงินไม่คืนสินค้า");
            builder.Property(e => e.RetProductReason).HasColumnType("varchar(25)").IsRequired().HasComment("สาเหตุการคืนสินค้า");
            builder.Property(e => e.deliverycode).HasColumnType("varchar(25)").IsRequired().HasComment("เลขที่ใบส่งสินค้า");
            builder.Property(e => e.vattype).HasColumnType("varchar(25)").IsRequired().HasComment("ภาษีมูลค่าเพิ่ม");
            builder.Property(e => e.vatrate).HasColumnType("decimal(18, 2)").IsRequired().HasComment("อัตราภาษีมูลค่าเพิ่ม");
            builder.Property(e => e.vatisout).HasColumnType("varchar(1)").IsRequired().HasComment("แยกนอก/รวมใน");
            builder.Property(e => e.CreditTerm).HasColumnType("decimal(18, 0)").IsRequired().HasComment("เครดิตเทอม");
            builder.Property(e => e.vatdue).HasColumnType("varchar(1)").IsRequired().HasComment("ภาษีมูลค่าเพิ่ม");
            builder.Property(e => e.islocked).HasColumnType("varchar(1)").IsRequired().HasComment("ล็อครายการ");
            builder.Property(e => e.approvedby).HasColumnType("varchar(25)").IsRequired().HasComment("ผู้อนุมัติเอกสาร");
            builder.Property(e => e.remark01).HasColumnType("varchar(255)").IsRequired().HasComment("หมายเหตุ 01");
            builder.Property(e => e.remark02).HasColumnType("varchar(225)").IsRequired().HasComment("หมายเหตุ 02");
            builder.Property(e => e.remark03).HasColumnType("varchar(255)").IsRequired().HasComment("หมายเหตุ 03");
            builder.Property(e => e.remark04).HasColumnType("varchar(255)").IsRequired().HasComment("หมายเหตุ 04");
            builder.Property(e => e.remark05).HasColumnType("varchar(255)").IsRequired().HasComment("หมายเหตุ 05");
            builder.Property(e => e.remark06).HasColumnType("varchar(255)").IsRequired().HasComment("หมายเหตุ 06");
            builder.Property(e => e.remark07).HasColumnType("varchar(255)").IsRequired().HasComment("หมายเหตุ 07");
            builder.Property(e => e.remark08).HasColumnType("varchar(255)").IsRequired().HasComment("หมายเหตุ 08");
            builder.Property(e => e.remark09).HasColumnType("varchar(255)").IsRequired().HasComment("หมายเหตุ 09");
            builder.Property(e => e.remark10).HasColumnType("varchar(255)").IsRequired().HasComment("หมายเหตุ 10");
            builder.Property(e => e.attach_file_01).HasColumnType("varchar(255)").IsRequired().HasComment("เก็บเฉพาะชื่อไฟล์เท่านั้น");
            builder.Property(e => e.attach_file_02).HasColumnType("varchar(255)").IsRequired().HasComment("เก็บเฉพาะชื่อไฟล์เท่านั้น");
            builder.Property(e => e.attach_file_03).HasColumnType("varchar(255)").IsRequired().HasComment("เก็บเฉพาะชื่อไฟล์เท่านั้น");
            builder.Property(e => e.attach_file_04).HasColumnType("varchar(255)").IsRequired().HasComment("เก็บเฉพาะชื่อไฟล์เท่านั้น");
            builder.Property(e => e.attach_file_05).HasColumnType("varchar(255)").IsRequired().HasComment("เก็บเฉพาะชื่อไฟล์เท่านั้น");
            builder.Property(e => e.footcurrdiscstr).HasColumnType("varchar(100)").IsRequired().HasComment("ส่วนลดท้ายบิล");

            builder.Property(e => e.footcurrdisamtitem).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าส่วนลด(Currency)");
            builder.Property(e => e.footstddisamtitem).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าส่วนลด(Standard)");
            builder.Property(e => e.footcurrpayamount).HasColumnType("decimal(18, 2)").IsRequired().HasComment("จำนวนเงินที่จ่าย(Currency)");
            builder.Property(e => e.footstdpayamount).HasColumnType("decimal(18, 2)").IsRequired().HasComment("จำนวนเงินที่จ่าย(Standard)");
            builder.Property(e => e.foottotalqty).HasColumnType("decimal(18, 0)").IsRequired().HasComment("จำนวนสินค้าทั้งหมด");
            builder.Property(e => e.footcurramt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสินค้า");
            builder.Property(e => e.footstdamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสินค้า");
            builder.Property(e => e.footcurrdiscamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("ส่วนลดท้ายบิล");
            builder.Property(e => e.footstddiscamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("ส่วนลดท้ายบิล");
            builder.Property(e => e.footcurrafdiscamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าหลังหักส่วนลด");
            builder.Property(e => e.footstdafdiscamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าหลังหักส่วนลด");
            builder.Property(e => e.footdepositamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าเงินมัดจำ");
            builder.Property(e => e.footcurrafdepositamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าหลัง หัก เงินมัดจำ");
            builder.Property(e => e.footstdafdepositamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าหลัง หัก เงินมัดจำ");
            builder.Property(e => e.footcurrwithouttaxamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสินค้าไม่มีภาษี");
            builder.Property(e => e.footstdwithouttaxamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสินค้าไม่มีภาษี");
            builder.Property(e => e.footcurrwithtaxamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสินค้ามีภาษี");
            builder.Property(e => e.footstdwithtaxamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสินค้ามีภาษี");
            builder.Property(e => e.footcurrbfvatamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสินค้าก่อนภาษี");
            builder.Property(e => e.footstdbfvatamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสินค้าก่อนภาษี");
            builder.Property(e => e.footcurrvatamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าภาษี");
            builder.Property(e => e.footstdvatamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าภาษี");
            builder.Property(e => e.footwithholdingtaxamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("ภาษีหัก ณ ที่จ่าย");
            builder.Property(e => e.footcurrnetamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสุทธิ(Currency)");
            builder.Property(e => e.footstdnetamt).HasColumnType("decimal(18, 2)").IsRequired().HasComment("มูลค่าสุทธิ(Standard)");


            builder.HasOne(p => p.Company).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Customer).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.customerid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Vendor).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.vendorid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Contact).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.contactid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Currency).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.currencyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SaleMan).WithMany(p => p.InvTrnHs).HasForeignKey(e => e.salemanid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}