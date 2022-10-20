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
    internal class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("menu");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(250)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(250)");
            builder.Property(e => e.desc1).HasColumnType("text");
            builder.Property(e => e.desc2).HasColumnType("text");
            builder.Property(e => e.parrentmenu).HasColumnType("varchar(50)");
            builder.Property(e => e.path).HasColumnType("varchar(1000)");
            builder.Property(e => e.module).HasColumnType("varchar(50)");
            builder.Property(e => e.menutype).HasColumnType("varchar(50)");
            builder.Property(e => e.icon).HasColumnType("varchar(100)");
            builder.Property(e => e.command).HasColumnType("varchar(255)");
            builder.Property(e => e.color).HasColumnType("varchar(100)");


            //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
