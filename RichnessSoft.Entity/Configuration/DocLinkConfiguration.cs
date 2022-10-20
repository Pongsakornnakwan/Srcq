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
    internal class DocLinkConfiguration : IEntityTypeConfiguration<DocLink>
    {
        public void Configure(EntityTypeBuilder<DocLink> builder)
        {
            builder.ToTable("doclink");
            builder.HasKey(m => m.id);
            builder.Property(e => e.qty).HasColumnType("decimal(18,2)");
            builder.Property(e => e.amount).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Company).WithMany(p => p.DocLinks).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.DocLinks).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.DocLinks).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.DocLinks).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.DocLinks).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.DocLinks).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.DocLinks).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
