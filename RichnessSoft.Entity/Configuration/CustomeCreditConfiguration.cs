using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Entity.Configuration
{
    public class CustomeCreditConfiguration : IEntityTypeConfiguration<CustomerCredit>
    {
        public void Configure(EntityTypeBuilder<CustomerCredit> builder)
        {
            builder.ToTable("customecredit");
            builder.HasKey(m => m.id);
            builder.Property(e => e.CreditType).HasColumnType("varchar(50)").IsRequired().HasComment("ประเภทเครดิต I = วงเงินเครดิตเพิ่ม , R = วงเงินเครดิตลด");
            builder.Property(e => e.amount).HasColumnType("decimal(18,2)").HasComment("จำนวนเงิน");
            builder.Property(e => e.reftype).HasColumnType("varchar(1)");
            builder.Property(e => e.seq).HasColumnType("varchar(1)").HasComment("`ลำดับ");

            builder.HasOne(p => p.Company).WithMany(p => p.CustomeCredits).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}