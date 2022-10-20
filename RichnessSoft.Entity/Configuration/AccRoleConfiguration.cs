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
    internal class AccRoleConfiguration : IEntityTypeConfiguration<AccRole>
    {
        public void Configure(EntityTypeBuilder<AccRole> builder)
        {
            builder.ToTable("accrole");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(25)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(255)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(255)");
            builder.Property(e => e.description).HasColumnType("varchar(100)");
            builder.Property(e => e.sysvariable).HasColumnType("varchar(100)");

            builder.HasOne(d => d.Company).WithMany(p => p.AccRoles).HasForeignKey(d => d.companyid).OnDelete(DeleteBehavior.Restrict);

        }

}
}
