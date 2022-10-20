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
    internal class DocTypeConfiguration : IEntityTypeConfiguration<DocType>
    {
        public void Configure(EntityTypeBuilder<DocType> builder)
        {
            builder.ToTable("doctype");
            builder.HasKey(m => m.id);
            builder.Property(e => e.system).HasColumnType("varchar(10)");
            builder.Property(e => e.menu).HasColumnType("varchar(50)");
            builder.Property(e => e.type).HasColumnType("varchar(100)");
            builder.Property(e => e.doc_group).HasColumnType("varchar(2)");
            builder.Property(e => e.code).HasColumnType("varchar(10)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(500)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(500)");
            builder.Property(e => e.vat).HasColumnType("varchar(10)");
            builder.Property(e => e.cash).HasColumnType("varchar(10)");
            builder.Property(e => e.service).HasColumnType("varchar(10)");
            builder.Property(e => e.tax_refund).HasColumnType("varchar(10)");



            //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
