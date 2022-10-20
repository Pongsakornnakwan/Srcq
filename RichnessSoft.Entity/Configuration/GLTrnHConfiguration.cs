
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
    internal class GLTrnHConfiguration : IEntityTypeConfiguration<GLTrnH>
    {
        public void Configure(EntityTypeBuilder<GLTrnH> builder)
        {
            builder.ToTable("gltrnh");
            builder.HasKey(m => m.id);
            builder.Property(e => e.freqacct).HasColumnType("varchar(25)");
            builder.Property(e => e.doctype).HasColumnType("varchar(4)");
            builder.Property(e => e.source).HasColumnType("varchar(6)");
            builder.Property(e => e.detail01).HasColumnType("varchar(255)");
            builder.Property(e => e.detail02).HasColumnType("varchar(255)");
            builder.Property(e => e.detail03).HasColumnType("varchar(255)");
            builder.Property(e => e.detail04).HasColumnType("varchar(255)");
            builder.Property(e => e.detail05).HasColumnType("varchar(255)");
            builder.Property(e => e.doccode).HasColumnType("varchar(25)");
            builder.Property(e => e.approvedby).HasColumnType("varchar(25)");
            builder.Property(e => e.status).HasColumnType("varchar(4)");
            builder.Property(e => e.islock).HasColumnType("varchar(2)");
            builder.Property(e => e.debitamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.creditamt).HasColumnType("decimal(18,2)");
            builder.Property(e => e.bookkeeping).HasColumnType("varchar(1)");

            builder.HasOne(p => p.Company).WithMany(p => p.GLTrnHs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.GLTrnHs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.AccBook).WithMany(p => p.GLTrnHs).HasForeignKey(e => e.accbookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.GLTrnHs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.GLTrnHs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.GLTrnHs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.GLTrnHs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

