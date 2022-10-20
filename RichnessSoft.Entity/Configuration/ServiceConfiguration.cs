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
    internal class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("service");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(30)").IsRequired();
            builder.Property(e => e.status).HasColumnType("varchar(1)");
            builder.Property(e => e.name1).HasColumnType("varchar(160)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");
            builder.Property(e => e.sname).HasColumnType("varchar(160)");
            builder.Property(e => e.name2).HasColumnType("varchar(160)");
            builder.Property(e => e.sname2).HasColumnType("varchar(160)");
            builder.Property(e => e.prodtype).HasColumnType("varchar(25)");
            builder.Property(e => e.taxrate).HasColumnType("varchar(1)");
            builder.Property(e => e.inputtax).HasColumnType("varchar(1)");
            builder.Property(e => e.salestax).HasColumnType("varchar(1)");
            builder.Property(e => e.stockcounting).HasColumnType("varchar(1)");
            builder.Property(e => e.showinventories).HasColumnType("varchar(1)");
            builder.Property(e => e.purchaseprice).HasColumnType("varchar(1)");
            builder.Property(e => e.saleprice).HasColumnType("varchar(1)");
            builder.Property(e => e.remark1).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark2).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark3).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark4).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark5).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark6).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark7).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark8).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark9).HasColumnType("varchar(1000)");
            builder.Property(e => e.remark10).HasColumnType("varchar(1000)");
            builder.Property(e => e.vattype).HasColumnType("varchar(10)");
            builder.Property(e => e.commision).HasColumnType("varchar(1)");
            builder.Property(e => e.cardfee).HasColumnType("varchar(1)");


            builder.HasOne(p => p.Company).WithMany(p => p.Services).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ProductGroup).WithMany(p => p.Services).HasForeignKey(e => e.productgroupid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Category).WithMany(p => p.Services).HasForeignKey(e => e.categoryid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Brand).WithMany(p => p.Services).HasForeignKey(e => e.brandid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Format).WithMany(p => p.Services).HasForeignKey(e => e.formatid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Design).WithMany(p => p.Services).HasForeignKey(e => e.designid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Grade).WithMany(p => p.Services).HasForeignKey(e => e.gradeid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Model).WithMany(p => p.Services).HasForeignKey(e => e.modelid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Size).WithMany(p => p.Services).HasForeignKey(e => e.sizeid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Color).WithMany(p => p.Services).HasForeignKey(e => e.colorid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Weight).WithMany(p => p.Services).HasForeignKey(e => e.weightid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}