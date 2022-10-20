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
    internal class BookBankConfiguration : IEntityTypeConfiguration<BookBank>
    {
        public void Configure(EntityTypeBuilder<BookBank> builder)
        {
            builder.ToTable("bookbank");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(150)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");
            builder.Property(e => e.bookno).HasColumnType("varchar(50)").HasDefaultValue("").HasComment("เลขที่สมุดบัญชีธนาคาร");
            builder.Property(e => e.sname1).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("ชื่อย่อ");
            builder.Property(e => e.sname1).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("ชื่อย่อ 2");
            builder.Property(e => e.sname1).HasColumnType("varchar(150)").HasDefaultValue("").HasComment("ชื่อย่อ 2");
            builder.Property(e => e.bookbanktype).HasColumnType("varchar(2)").HasDefaultValue("").HasComment("ประเภทสมุดบัญชี");
            builder.Property(e => e.balanceamount).HasColumnType("decimal(18,2)").HasDefaultValue(0).HasComment("จำนวนเงินฝาก");
            builder.Property(e => e.blancedate).HasComment("Balance date");
            builder.Property(e => e.acchartid).HasComment("ผังบัญชี");
            builder.Property(e => e.recivecqacchartid).HasComment("บัญชีเช็ครับ");
            builder.Property(e => e.paymentcqacchartid).HasComment("บัญชีเช็คจ่าย");
            builder.Property(e => e.depositbookid).HasComment("เล่มบันทึกใบนำฝาก");
            builder.Property(e => e.revertcqacchartid).HasComment("กลับรายการเช็คจ่าย");
            builder.Property(e => e.trandferacchartid).HasComment("บัญชีโอนเงินระหว่างสมุด");

            builder.HasOne(p => p.Company).WithMany(p => p.BookBanks).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Bank).WithMany(p => p.BookBanks).HasForeignKey(e => e.bankid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.BankBranch).WithMany(p => p.BookBanks).HasForeignKey(e => e.bankbranchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Acchart).WithMany(p => p.BookBanks).HasForeignKey(e => e.acchartid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}