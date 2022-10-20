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
    internal class SysOptionConfiguration : IEntityTypeConfiguration<SysOption>
    {
        public void Configure(EntityTypeBuilder<SysOption> builder)
        {
            builder.ToTable("sysoption");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.postaccount).HasColumnType("varchar(1)");
            builder.Property(e => e.vattype).HasColumnType("varchar(1)");
            builder.Property(e => e.vatisout).HasColumnType("varchar(1)");
            builder.Property(e => e.taxapproveno).HasColumnType("varchar(100)");
            builder.Property(e => e.taxpayname).HasColumnType("varchar(200)");
            builder.Property(e => e.taxpayposition).HasColumnType("varchar(200)");
            builder.Property(e => e.stockcounting).HasColumnType("varchar(1)");
            builder.Property(e => e.controllot).HasColumnType("varchar(10)");
            builder.Property(e => e.controlserial).HasColumnType("varchar(10)");
            builder.Property(e => e.fgcost).HasColumnType("varchar(1)");
            builder.Property(e => e.rmcost).HasColumnType("varchar(1)");
            builder.Property(e => e.cscost).HasColumnType("varchar(1)");
            builder.Property(e => e.fgglpost).HasColumnType("varchar(2)");
            builder.Property(e => e.rmglpost).HasColumnType("varchar(2)");
            builder.Property(e => e.csglpost).HasColumnType("varchar(2)");
            builder.Property(e => e.selectbuyprice).HasColumnType("varchar(30)");
            builder.Property(e => e.selectsaleprice).HasColumnType("varchar(30)");
            builder.Property(e => e.costcnbuy).HasColumnType("varchar(10)");
            builder.Property(e => e.costcnsale).HasColumnType("varchar(10)");
            builder.Property(e => e.costproductzero).HasColumnType("varchar(10)");
            builder.Property(e => e.costcountstockdoc).HasColumnType("varchar(10)");
            builder.Property(e => e.costreturnwithdraw).HasColumnType("varchar(10)");
            builder.Property(e => e.glyearmode).HasColumnType("varchar(10)");
            builder.Property(e => e.glformatdoc).HasColumnType("varchar(10)");
            builder.Property(e => e.glheadmessage).HasColumnType("varchar(100)");
            builder.Property(e => e.docyearmode).HasColumnType("varchar(10)");
            builder.Property(e => e.docformatdoc).HasColumnType("varchar(10)");
        }
    }
}
