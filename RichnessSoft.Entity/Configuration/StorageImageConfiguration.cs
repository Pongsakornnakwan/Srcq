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
    internal class StorageImageConfiguration : IEntityTypeConfiguration<StorageImage>
    {
        public void Configure(EntityTypeBuilder<StorageImage> builder)
        {
            builder.ToTable("storageimage");
            builder.HasKey(m => m.id);
            builder.Property(e => e.sourceimage).HasColumnType("varchar(100)");
            builder.Property(e => e.refdocid).HasColumnType("varchar(25)");
            builder.Property(e => e.source).HasColumnType("varchar(255)");
            builder.Property(e => e.alt).HasColumnType("varchar(255)");
            builder.Property(e => e.caption).HasColumnType("varchar(255)");
            builder.Property(e => e.header).HasColumnType("varchar(255)");
            builder.Property(e => e.seq).HasColumnType("varchar(4)");

            //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid);
        }
    }
}

