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
    public class AccRoleTemplateHConfiguration : IEntityTypeConfiguration<AccRoleTemplateH>
    {
        public void Configure(EntityTypeBuilder<AccRoleTemplateH> builder)
        {
            builder.ToTable("accroletemplateh");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(25)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(150)");
            builder.Property(e => e.description).HasColumnType("varchar(100)");

            builder.HasOne(d => d.Company)
           .WithMany(p => p.AccRoleTemplateHs)
           .HasForeignKey(d => d.companyid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
