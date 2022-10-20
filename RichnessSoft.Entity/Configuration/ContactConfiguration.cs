using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Entity.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("contact");
            builder.HasKey(m => m.id);
            builder.Property(e => e.contactname).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.positionname).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.remark).HasColumnType("varchar(150)");
            builder.Property(e => e.mobile).HasColumnType("varchar(150)");
            builder.Property(e => e.tel).HasColumnType("varchar(150)");
            builder.Property(e => e.companyname).HasColumnType("varchar(150)");
            builder.Property(e => e.seq).HasColumnType("varchar(50)");

            builder.HasOne(p => p.Company).WithMany(p => p.Contacts).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}