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
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("book");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(150)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");
            builder.Property(e => e.prefixrunno).HasColumnType("varchar(20)").HasDefaultValue("").HasComment("ขึ้นต้น");
            builder.Property(e => e.yearrunno).HasColumnType("varchar(20)").HasDefaultValue("").HasComment("รูปแบบปี ");
            builder.Property(e => e.docformatrunno).HasColumnType("varchar(20)").HasDefaultValue("").HasComment("รูปแบบการ Running เอกสาร");
            builder.Property(e => e.doclenrunno).HasDefaultValue(0).HasComment("จำนวนหลักในการ Running");
            builder.Property(e => e.docstartrunno).HasDefaultValue(0).HasComment("เลขที่เริ่มต้น");
            builder.Property(e => e.lockdate).HasComment("Lock ข้อมูลห้ามแก้ไข ถึงวันที่");
            builder.Property(e => e.accremarkdetail).HasComment("หมายเหตุการลงลัญชี");
            builder.Property(e => e.vattype).HasColumnType("varchar(20)").HasDefaultValue("").HasComment("ประเภทภาษี ");

            builder.HasOne(p => p.Company).WithMany(p => p.Books).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.Books).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.AccBook).WithMany(p => p.Books).HasForeignKey(e => e.accbookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.AccRoleTemplateH).WithMany(p => p.Books).HasForeignKey(e => e.accroletemplatehid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}