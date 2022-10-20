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
    internal class SaleManConfiguration : IEntityTypeConfiguration<SaleMan>
    {
        public void Configure(EntityTypeBuilder<SaleMan> builder)
        {
            builder.ToTable("saleman");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.card_no).HasColumnType("varchar(25)");
            builder.Property(e => e.prefix_th).HasColumnType("varchar(30)");
            builder.Property(e => e.prefix_en).HasColumnType("varchar(30)");
            builder.Property(e => e.name1).HasColumnType("varchar(250)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(250)");
            builder.Property(e => e.tel).HasColumnType("varchar(20)");
            builder.Property(e => e.mobile).HasColumnType("varchar(20)");
            builder.Property(e => e.line).HasColumnType("varchar(100)");
            builder.Property(e => e.email).HasColumnType("varchar(100)");
            builder.Property(e => e.position).HasColumnType("varchar(50)");
            builder.Property(e => e.login).HasColumnType("varchar(100)");
            builder.Property(e => e.sale_team).HasColumnType("varchar(50)");
            builder.Property(e => e.sale_area).HasColumnType("varchar(50)");
            builder.Property(e => e.commission).HasColumnType("decimal(18,2)");
            builder.Property(e => e.signature).HasColumnType("varchar(1000)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");

            builder.HasOne(p => p.Company).WithMany(p => p.SaleMans).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}