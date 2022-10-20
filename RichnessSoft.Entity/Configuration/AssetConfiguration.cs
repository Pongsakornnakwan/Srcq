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
    internal class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.ToTable("asset");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(25)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(255)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(255)");
            builder.Property(e => e.identity).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("เป็นสินทรัพย์มีตัวตัว");
            builder.Property(e => e.generate).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("ต้องการคำนวณค่าเสื่อม YES = ต้องการคำนวณ, NO = ไม่ต้องการคำนวณ");
            builder.Property(e => e.buyprice).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("ราคาซื้อ");
            builder.Property(e => e.transportexpense).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("ค่าใช้จ่ายในการขนส่ง");
            builder.Property(e => e.setupexpense).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("ค่าใช้จ่ายในการติดตั้ง");
            builder.Property(e => e.miscellaneousexpense).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("ค่าใช้จ่ายเบ็ดเตล็ด");
            builder.Property(e => e.totalprice).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("รวมราคาซื้อหรือได้มา");
            builder.Property(e => e.amount).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("มูลค่าที่ใช้ในการคำนวณ");
            builder.Property(e => e.amountdepreciat).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("มูลค่าค่าเสื่อมสะสม");
            builder.Property(e => e.buydate).HasColumnType("date").HasComment("วันที่ซื้อ");
            builder.Property(e => e.buyinv).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("เลขที่บิลซื้อ");
            builder.Property(e => e.buyvoucher).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("Payment Voucher");
            builder.Property(e => e.startdate).HasColumnType("date").HasComment("วันที่เริ่มคำนวณ");
            builder.Property(e => e.method).HasColumnType("varchar(1)").HasDefaultValue("S").HasComment("วิธีการคำนวณ S = เส้นตรง (Straight line) , D = ลดน้อยถอยลง (DDB)");
            builder.Property(e => e.voucherrecord).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("บันทึกบัญชีทุกๆ M = เดือน , Y = ปี ");
            builder.Property(e => e.rate).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("% อัตราคาเสื่อม");
            builder.Property(e => e.rateper).HasColumnType("varchar(1)").HasDefaultValue(0).HasComment("อัตราต่อ M = เดือน , Y = ปี ");
            builder.Property(e => e.rate2).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("% อัตรา ณ วันที่ได้มา");
            builder.Property(e => e.salvage).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("ค่าซาก");
            builder.Property(e => e.deduct).HasColumnType("varchar(1)").HasDefaultValue("N").HasComment("หัก มูลค่าซาก YES = ต้องการหัก , NO = ไม่ต้องการหัก ");
            builder.Property(e => e.stopdate).HasComment("วันที่หยุดคำนวณ");
            builder.Property(e => e.saledate).HasComment("วันที่ขายไป");
            builder.Property(e => e.saleinv).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("เลขที่บิลขาย");
            builder.Property(e => e.salevoucher).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("Receipt Voucher");
            builder.Property(e => e.customer).HasColumnType("varchar(300)").HasDefaultValue("").HasComment("ขายให้");
            builder.Property(e => e.vendor).HasColumnType("varchar(300)").HasDefaultValue("").HasComment("ซื้อจาก");
            builder.Property(e => e.brand).HasColumnType("varchar(300)").HasDefaultValue("").HasComment("ยี่ห้อ");
            builder.Property(e => e.series).HasColumnType("varchar(300)").HasDefaultValue("").HasComment("รุ่น");
            builder.Property(e => e.usefullife).HasColumnType("varchar(20)").HasDefaultValue("").HasComment("อายุการใช้งาน");
            builder.Property(e => e.warrantyno).HasColumnType("varchar(100)").HasDefaultValue("").HasComment("หมายเลขประกัน");
            builder.Property(e => e.insurancecomp).HasColumnType("varchar(300)").HasDefaultValue("").HasComment("บริษัทประกันภัย");
            builder.Property(e => e.insuranceno).HasColumnType("varchar(300)").HasDefaultValue("").HasComment("เลขที่กรมธรรน์");
            builder.Property(e => e.remark).HasColumnType("varchar(1000)").HasDefaultValue("").HasComment("เลขที่กรมธรรน์");

            builder.HasOne(d => d.Company).WithMany(p => p.Assets).HasForeignKey(d => d.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.AssetGroup).WithMany(p => p.Assets).HasForeignKey(d => d.assetgroupid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Branch).WithMany(p => p.Assets).HasForeignKey(d => d.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Acchart).WithMany(p => p.Assets).HasForeignKey(d => d.acchartid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
