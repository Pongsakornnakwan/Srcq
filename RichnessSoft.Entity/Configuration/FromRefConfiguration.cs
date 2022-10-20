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
    internal class FromRefConfiguration : IEntityTypeConfiguration<FromRef>
    {
        public void Configure(EntityTypeBuilder<FromRef> builder)
        {
            builder.ToTable("fromref");
            builder.HasKey(m => m.id);
            builder.Property(e => e.reffromtable).HasColumnType("varchar(50)");
            builder.Property(e => e.reffromcode).HasColumnType("varchar(50)");
            builder.Property(e => e.formtype).HasColumnType("varchar(50)");
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.name).HasColumnType("varchar(50)").IsRequired();


            builder.HasOne(p => p.Company).WithMany(p => p.FromRefs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
