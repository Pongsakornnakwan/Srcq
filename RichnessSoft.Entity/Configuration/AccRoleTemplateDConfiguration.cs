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
    internal class AccRoleTemplateDConfiguration : IEntityTypeConfiguration<AccRoleTemplateD>
    {
        public void Configure(EntityTypeBuilder<AccRoleTemplateD> builder)
        {
            builder.ToTable("accroletemplated");
            builder.HasKey(m => m.id);
            builder.Property(e => e.accrolecode).HasColumnType("varchar(25)").IsRequired();
            builder.Property(e => e.accroledesc).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.accroledesc2).HasColumnType("varchar(150)");

            builder.HasOne(p => p.Acchart).WithMany(p => p.AccRoleTemplateDs).HasForeignKey(e => e.acchartid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.AccRoleTemplateH).WithMany(p => p.AccRoleTemplateDs).HasForeignKey(e => e.accroletemplatehid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
