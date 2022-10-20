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
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("company");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(25)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(255)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(255)");
            builder.Property(e => e.taxid).HasColumnType("varchar(50)");
            builder.Property(e => e.houseno).HasColumnType("varchar(50)");
            builder.Property(e => e.moo).HasColumnType("varchar(50)");
            builder.Property(e => e.floor).HasColumnType("varchar(50)");
            builder.Property(e => e.room).HasColumnType("varchar(50)");
            builder.Property(e => e.village).HasColumnType("varchar(100)");
            builder.Property(e => e.village2).HasColumnType("varchar(100)");
            builder.Property(e => e.building).HasColumnType("varchar(100)");
            builder.Property(e => e.building2).HasColumnType("varchar(100)");
            builder.Property(e => e.lane).HasColumnType("varchar(100)");
            builder.Property(e => e.lane2).HasColumnType("varchar(100)");
            builder.Property(e => e.yaek).HasColumnType("varchar(10)");
            builder.Property(e => e.road).HasColumnType("varchar(10)");
            builder.Property(e => e.road2).HasColumnType("varchar(10)");
            builder.Property(e => e.subdisrictid).HasColumnType("varchar(10)");
            builder.Property(e => e.disrictid).HasColumnType("varchar(10)");
            builder.Property(e => e.provinceid).HasColumnType("varchar(10)");
            builder.Property(e => e.countryid).HasColumnType("varchar(10)");
            builder.Property(e => e.postalid).HasColumnType("varchar(10)");
            builder.Property(e => e.tel2).HasColumnType("varchar(10)");
            builder.Property(e => e.tel).HasColumnType("varchar(10)");
            builder.Property(e => e.fax).HasColumnType("varchar(10)");
            builder.Property(e => e.website).HasColumnType("varchar(10)");
            builder.Property(e => e.onwername).HasColumnType("varchar(10)");
            builder.Property(e => e.registerno).HasColumnType("varchar(10)");
        }
    }
}
