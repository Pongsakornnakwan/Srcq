

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
    internal class GLTrnDConfiguration : IEntityTypeConfiguration<GLTrnD>
    {
        public void Configure(EntityTypeBuilder<GLTrnD> builder)
        {
            builder.ToTable("gltrnd");
            builder.HasKey(m => m.id);
            builder.Property(e => e.doctype).HasColumnType("varchar(4)");
            builder.Property(e => e.group).HasColumnType("varchar(255)");
            builder.Property(e => e.detail01).HasColumnType("varchar(4000)");
            builder.Property(e => e.detail02).HasColumnType("varchar(4000)");
            builder.Property(e => e.detail03).HasColumnType("varchar(4000)");
            builder.Property(e => e.detail04).HasColumnType("varchar(4000)");
            builder.Property(e => e.detail05).HasColumnType("varchar(4000)");
            builder.Property(e => e.creditamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.debitamt).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Company).WithMany(p => p.GLTrnDs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.GLTrnDs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.AccBook).WithMany(p => p.GLTrnDs).HasForeignKey(e => e.accbookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.GLTrnDs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.GLTrnDs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.GLTrnDs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.GLTrnDs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.GLTrnH).WithMany(p => p.GLTrnDs).HasForeignKey(e => e.gltrnhid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

