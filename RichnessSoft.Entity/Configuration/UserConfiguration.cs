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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");
            builder.HasKey(m => m.id);
            builder.Property(e => e.username).HasColumnType("varchar(50)");
            builder.Property(e => e.password).HasColumnType("varchar(150)");
            builder.Property(e => e.firstname).HasColumnType("varchar(150)");
            builder.Property(e => e.lastname).HasColumnType("varchar(150)");
            builder.Property(e => e.email).HasColumnType("varchar(150)");
            builder.Property(e => e.token).HasColumnType("varchar(1000)");
            builder.Property(e => e.confirmpassword).HasColumnType("varchar(150)");
            builder.Property(e => e.usertype).HasColumnType("varchar(150)");

            //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}