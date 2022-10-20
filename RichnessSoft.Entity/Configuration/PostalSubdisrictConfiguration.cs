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
    internal class PostalSubdisrictConfiguration : IEntityTypeConfiguration<PostalSubdisrict>
    {
        public void Configure(EntityTypeBuilder<PostalSubdisrict> builder)
        {
            builder.ToTable("postalsubdisrict");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(10)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(250)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(250)");
            builder.Property(e => e.disrictcode).HasColumnType("varchar(250)");
            builder.Property(e => e.provincecode).HasColumnType("varchar(250)");
            builder.Property(e => e.countrycode).HasColumnType("varchar(250)");
            builder.Property(e => e.postal_code).HasColumnType("varchar(5)");

            //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
