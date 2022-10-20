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
    internal class BilpayConfiguration : IEntityTypeConfiguration<Bilpay>
    {
        public void Configure(EntityTypeBuilder<Bilpay> builder)
        {
            builder.ToTable("bilpay");
            builder.HasKey(m => m.id);
            builder.Property(e => e.gltrnhid).HasColumnType("varchar(25)");
            builder.Property(e => e.masterid).HasColumnType("varchar(25)");
            builder.Property(e => e.doctype).HasColumnType("varchar(4)");
            builder.Property(e => e.paymentid).HasColumnType("varchar(25)");
            builder.Property(e => e.status).HasColumnType("varchar(4)");
            builder.Property(e => e.amount).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Company).WithMany(p => p.Bilpays).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.Bilpays).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}

