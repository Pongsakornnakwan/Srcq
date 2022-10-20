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
    internal class InvTrnDConfiguration : IEntityTypeConfiguration<InvTrnD>
    {
        public void Configure(EntityTypeBuilder<InvTrnD> builder)
        {
            builder.ToTable("invtrnd");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(4)").IsRequired().HasComment("ประเภทเอกสาร");
            builder.Property(e => e.docstatus).HasColumnType("varchar(4)").HasComment("สถานะ");
            builder.Property(e => e.gltrnhid).HasComment("บัญชีรายวัน");
            builder.Property(e => e.invtrnhid).HasComment("เลขที่ใบแจ้งหนี้ส่วนหัวเอกสาร");
            builder.Property(e => e.pstype).HasColumnType("varchar(25)").HasComment("(P)สินค้า/(S)ชุดสินค้า");
            builder.Property(e => e.Refund).HasColumnType("varchar(1)").HasComment("Y = คืน , N = ไม่คืน");
            builder.Property(e => e.ProdType).HasColumnType("varchar(25)").HasComment("ประเภทสินค้า");
            builder.Property(e => e.inouttype).HasColumnType("varchar(1)").HasComment("นำเข้า/ส่งออก");
            builder.Property(e => e.rootseq).HasColumnType("varchar(2)").HasComment("ลำดับชั้นชุดสินค้า");
            builder.Property(e => e.setparent).HasColumnType("varchar(25)").HasComment("ชุดสินค้าตัวคุมสินค้า");
            builder.Property(e => e.discstr).HasColumnType("varchar(25)").HasComment("ส่วนลด(คีย์)");
            builder.Property(e => e.vattype).HasColumnType("varchar(1)").HasComment("ประเภทภาษี");
            builder.Property(e => e.vatisout).HasColumnType("varchar(1)").HasComment("แยกนอก/รวมใน");
            builder.Property(e => e.vatrate).HasColumnType("decimal(18, 2)").HasComment("ภาษี");
            builder.Property(e => e.lot).HasColumnType("varchar(30)").HasComment("ฉลาก");
            builder.Property(e => e.Seq).HasColumnType("varchar(4)").HasComment("ลำดับรายการ");
            builder.Property(e => e.remark01).HasColumnType("varchar(255)").HasComment("Item remark 01");
            builder.Property(e => e.remark02).HasColumnType("varchar(255)").HasComment("Item remark 02");
            builder.Property(e => e.remark03).HasColumnType("varchar(255)").HasComment("Item remark 03");
            builder.Property(e => e.remark04).HasColumnType("varchar(255)").HasComment("Item remark 04");
            builder.Property(e => e.remark05).HasColumnType("varchar(255)").HasComment("Item remark 05");
            builder.Property(e => e.remark06).HasColumnType("varchar(255)").HasComment("Item remark 06");
            builder.Property(e => e.remark07).HasColumnType("varchar(255)").HasComment("Item remark 07");
            builder.Property(e => e.remark08).HasColumnType("varchar(255)").HasComment("Item remark 08");
            builder.Property(e => e.remark09).HasColumnType("varchar(255)").HasComment("Item remark 09");
            builder.Property(e => e.remark10).HasColumnType("varchar(255)").HasComment("Item remark 10");

            builder.Property(e => e.qty).HasColumnType("decimal(18, 2)").HasComment("จำนวน");
            builder.Property(e => e.backqty).HasColumnType("decimal(18, 2)").HasComment("จำนวนตัดคงเหลือ");
            builder.Property(e => e.qtystd).HasColumnType("decimal(18, 2)").HasComment("จำนวนมาตรฐาน");
            builder.Property(e => e.price).HasColumnType("decimal(18, 2)").HasComment("ราคา");
            builder.Property(e => e.pricek).HasColumnType("decimal(18, 2)").HasComment("ราคา(คีย์)");
            builder.Property(e => e.discamount).HasColumnType("decimal(18, 2)").HasComment("มูลค่าส่วนลด");
            builder.Property(e => e.discamountk).HasColumnType("decimal(18, 2)").HasComment("มูลค่าส่วนลด(คีย์)");
            builder.Property(e => e.xrate).HasColumnType("decimal(18, 2)").HasComment("อัตราแปลงหน่วย");
            builder.Property(e => e.bfvatamount).HasColumnType("decimal(18, 2)").HasComment("จำนวน(qty) x ราคาต่อหน่วย(price) - ส่วนลด(discamt)");
            builder.Property(e => e.bfvatamountk).HasColumnType("decimal(18, 2)").HasComment("จำนวน(qty) x ราคาต่อหน่วย(price) - ส่วนลด(discamt)");
            builder.Property(e => e.amount).HasColumnType("decimal(18, 2)").HasComment("Before VAT amount + จำนวนภาษี");
            builder.Property(e => e.amountk).HasColumnType("decimal(18, 2)").HasComment("จำนวน(qty) x ราคาต่อหน่วย(pricek) - ส่วนลด(DiscAmtK)");
            builder.Property(e => e.vatrate).HasColumnType("decimal(18, 2)").HasComment("อัตตราภาษี");
            builder.Property(e => e.vatamount).HasColumnType("decimal(18, 2)").HasComment("จำนวนภาษี");
            builder.Property(e => e.vatamountk).HasColumnType("decimal(18, 2)").HasComment("จำนวนภาษี(คีย์)");
            builder.Property(e => e.costamount).HasColumnType("decimal(18, 2)").HasComment("มูลค่าต้นทุน");
            builder.Property(e => e.costadj).HasColumnType("decimal(18, 2)").HasComment("มูลค่าต้นทุนเพิ่มเติม");
            builder.Property(e => e.costavg).HasColumnType("decimal(18, 2)").HasComment("มูลค่าต้นทุนเฉลี่ย");
            builder.Property(e => e.costfifo).HasColumnType("decimal(18, 2)").HasComment("มูลค่าต้นทุน FIFO");
            builder.Property(e => e.costlot).HasColumnType("decimal(18, 2)").HasComment("มูลค่าต้นทุน lot");
            builder.Property(e => e.coststd).HasColumnType("decimal(18, 2)").HasComment("มูลค่าต้นทุน Std.");
            builder.Property(e => e.refdocqtyofcut).HasColumnType("decimal(18, 0)").HasComment("จำนวนที่ดึงมาตัดในเอกสารใบนี้");
            builder.Property(e => e.paycurramt).HasColumnType("decimal(18, 2)").HasComment("มูลค่าชำระ");
            builder.Property(e => e.paystdamt).HasColumnType("decimal(18, 2)").HasComment("มูลค่าชำระ");

            builder.HasOne(p => p.Company).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Customer).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.customerid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Vendor).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.vendorid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Product).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.productid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.InvTrnH).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.invtrnhid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Warehouse).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.warehouseid).OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(p => p.UM).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.umid).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(p => p.UM).WithMany(p => p.InvTrnDs).HasForeignKey(e => e.umstdid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}