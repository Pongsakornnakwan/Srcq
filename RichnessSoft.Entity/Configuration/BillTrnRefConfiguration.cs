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
    internal class BillTrnRefConfiguration : IEntityTypeConfiguration<BillTrnRef>
    {
        public void Configure(EntityTypeBuilder<BillTrnRef> builder)
        {
            builder.ToTable("billtrnref");
            builder.HasKey(m => m.id);
            builder.Property(e => e.docstatus).HasColumnType("varchar(50)");
            builder.Property(e => e.itemreftype).HasColumnType("varchar(25)");
            builder.Property(e => e.rate).HasColumnType("decimal(18,2)");
            builder.Property(e => e.bfcurrvatamount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.bfstdvatamount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.vatcurramount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.vatstdamount).HasColumnType("decimal(18,2)");




            // builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            //builder.Property(e => e.name1).HasColumnType("varchar(150)").IsRequired();
            // builder.Property(e => e.name2).HasColumnType("varchar(150)");
            // builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");

            builder.HasOne(p => p.Company).WithMany(p => p.BillTrnRefs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.BillTrnRefs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Book).WithMany(p => p.BillTrnRefs).HasForeignKey(e => e.bookid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Section).WithMany(p => p.BillTrnRefs).HasForeignKey(e => e.sectionid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Department).WithMany(p => p.BillTrnRefs).HasForeignKey(e => e.departmentid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany(p => p.BillTrnRefs).HasForeignKey(e => e.projectid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Plans).WithMany(p => p.BillTrnRefs).HasForeignKey(e => e.plansld).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
