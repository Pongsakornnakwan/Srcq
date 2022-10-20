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
    internal class AcchartConfiguration : IEntityTypeConfiguration<Acchart>
    {
        public void Configure(EntityTypeBuilder<Acchart> builder)
        {
            builder.ToTable("acchart");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(25)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(255)").IsRequired(); 
            builder.Property(e => e.name2).HasColumnType("varchar(255)");
            builder.Property(e => e.tag).HasColumnType("varchar(50)");
            builder.Property(e => e.tag2).HasColumnType("varchar(50)");
            builder.Property(e => e.group).HasColumnType("varchar(1)");
            builder.Property(e => e.active).HasColumnType("varchar(1)");
            builder.Property(e => e.inactivedate).HasColumnType("date");

            builder.HasOne(d => d.Company).WithMany(p => p.Accharts).HasForeignKey(d => d.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Company).WithMany(p => p.Accharts).HasForeignKey(d => d.companyid).OnDelete(DeleteBehavior.Restrict);

        }


    }
}
