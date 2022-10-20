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
    internal class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("payment");
            builder.HasKey(m => m.id);
            builder.Property(e => e.systype).HasColumnType("varchar(25)");
            builder.Property(e => e.depositwithdraw).HasColumnType("varchar(1)");
            builder.Property(e => e.paygroup).HasColumnType("varchar(1)");
            builder.Property(e => e.code).HasColumnType("varchar(25)");
            builder.Property(e => e.payrecv).HasColumnType("varchar(255)");
            builder.Property(e => e.payrecv2).HasColumnType("varchar(255)");
            builder.Property(e => e.paynameincheque).HasColumnType("varchar(255)");
            builder.Property(e => e.paynameincheque2).HasColumnType("varchar(255)");
            builder.Property(e => e.amount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.payamount).HasColumnType("decimal(18,2)");
            builder.Property(e => e.acpayee).HasColumnType("varchar(1)");
            builder.Property(e => e.orderbearer).HasColumnType("varchar(1)");
            builder.Property(e => e.stat).HasColumnType("varchar(1)");
            builder.Property(e => e.step).HasColumnType("varchar(1)");
            builder.Property(e => e.inout).HasColumnType("varchar(1)");
            builder.Property(e => e.returnattime).HasColumnType("decimal(18,2)");
            builder.Property(e => e.chequereturncode).HasColumnType("varchar(25)");
            builder.Property(e => e.remark01).HasColumnType("varchar(500)");

            builder.HasOne(p => p.Company).WithMany(p => p.Payments).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Branch).WithMany(p => p.Payments).HasForeignKey(e => e.branchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.GLTrnH).WithMany(p => p.Payments).HasForeignKey(e => e.gltrnhid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Bank).WithMany(p => p.Payments).HasForeignKey(e => e.bankid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.BankBranch).WithMany(p => p.Payments).HasForeignKey(e => e.bankbranchid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Customer).WithMany(p => p.Payments).HasForeignKey(e => e.customerid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Vendor).WithMany(p => p.Payments).HasForeignKey(e => e.vendorid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}