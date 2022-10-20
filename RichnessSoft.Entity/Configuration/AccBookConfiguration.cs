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
    public class AccBookConfiguration : IEntityTypeConfiguration<AccBook>
    {
        public void Configure(EntityTypeBuilder<AccBook> builder)
        {
            builder.ToTable("accbook");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(25)").IsRequired(); 
            builder.Property(e => e.name1).HasColumnType("varchar(255)").IsRequired(); 
            builder.Property(e => e.name2).HasColumnType("varchar(255)");

            builder.HasOne(d => d.Company).WithMany(p => p.Accbooks).HasForeignKey(d => d.companyid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
