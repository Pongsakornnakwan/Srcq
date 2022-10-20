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
    internal class PayInTrnDConfiguration : IEntityTypeConfiguration<PayInTrnD>
    {
        public void Configure(EntityTypeBuilder<PayInTrnD> builder)
        {
            builder.ToTable("payintrnd");
            builder.HasKey(m => m.id);
            builder.Property(e => e.stat).HasColumnType("varchar(1)");

            builder.HasOne(p => p.Company).WithMany(p => p.PayInTrnDs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.PayInTrnDs).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Payment).WithMany(p => p.PayInTrnDs).HasForeignKey(e => e.paymentid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}