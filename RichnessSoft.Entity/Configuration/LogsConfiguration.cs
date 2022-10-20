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
    internal class LogsConfiguration : IEntityTypeConfiguration<Logs>
    {
        public void Configure(EntityTypeBuilder<Logs> builder)
        {
            builder.ToTable("logs");
            builder.HasKey(m => m.id);
            builder.Property(e => e.message).HasColumnType("text");
            builder.Property(e => e.exception).HasColumnType("text");
            builder.Property(e => e.thread).HasColumnType("text");
            builder.Property(e => e.level).HasColumnType("text");
            builder.Property(e => e.logger).HasColumnType("text");

            //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }

    }
}