using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Entity.Configuration
{
    public class CustGroupConfiguration : IEntityTypeConfiguration<CustGroup>
    {
        public void Configure(EntityTypeBuilder<CustGroup> builder)
        {
            builder.ToTable("custgroup");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.Name).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(150)");
            builder.Property(e => e.Active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");


            builder.HasOne(p => p.Company).WithMany(p => p.CustGroups).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Acchart).WithMany(p => p.CustGroups).HasForeignKey(e => e.acchartid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}