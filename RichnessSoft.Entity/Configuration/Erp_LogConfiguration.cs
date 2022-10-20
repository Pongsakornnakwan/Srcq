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
    internal class Erp_LogConfiguration : IEntityTypeConfiguration<Erp_Log>
    {
        public void Configure(EntityTypeBuilder<Erp_Log> builder)
        {
            builder.ToTable("erp_log");
            builder.HasKey(m => m.id);
            builder.Property(e => e.logtype).HasColumnType("text");
            builder.Property(e => e.doc_no).HasColumnType("text");
            builder.Property(e => e.old_doc_no).HasColumnType("text");
            builder.Property(e => e.user_code).HasColumnType("text");
            builder.Property(e => e.data_new).HasColumnType("text");
            builder.Property(e => e.data_old).HasColumnType("text");


            //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
