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
    public class AssetGroupConfiguration : IEntityTypeConfiguration<AssetGroup>
    {
        public void Configure(EntityTypeBuilder<AssetGroup> builder)
        {
            builder.ToTable("assetgroup");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar").IsRequired().HasMaxLength(50);
            builder.Property(e => e.name1).HasColumnType("varchar(150)").IsRequired().HasMaxLength(150);
            builder.Property(e => e.name2).HasColumnType("varchar(150)").HasMaxLength(150);

            builder.HasOne(p => p.Company).WithMany(p => p.AssetGroups).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Acchart).WithMany(p => p.AssetGroups).HasForeignKey(e => e.acchartid).OnDelete(DeleteBehavior.Restrict).OnDelete(DeleteBehavior.Restrict);
        }
    }
}