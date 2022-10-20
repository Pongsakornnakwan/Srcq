using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Entity.Configuration
{
    internal class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");
            builder.HasKey(m => m.id);
            builder.Property(e => e.refid).HasColumnType("varchar(50)");
            builder.Property(e => e.taxpayer).HasColumnType("varchar(25)");
            builder.Property(e => e.taxrepprefix).HasColumnType("varchar(50)");
            builder.Property(e => e.taxrepfirstname).HasColumnType("varchar(100)");
            builder.Property(e => e.taxrepmidname).HasColumnType("varchar(100)");
            builder.Property(e => e.taxreplastname).HasColumnType("varchar(100)");
            builder.Property(e => e.taxrepfirstname2).HasColumnType("varchar(100)");
            builder.Property(e => e.taxrepmidname2).HasColumnType("varchar(100)");
            builder.Property(e => e.taxreplastname2).HasColumnType("varchar(100)");
            builder.Property(e => e.taxrepname).HasColumnType("varchar(255)");
            builder.Property(e => e.taxrepname2).HasColumnType("varchar(255)");
            builder.Property(e => e.taxrepsname).HasColumnType("varchar(255)");
            builder.Property(e => e.taxtepsname2).HasColumnType("varchar(255)");
            builder.Property(e => e.taxreptaxid).HasColumnType("varchar(25)");
            builder.Property(e => e.taxrepbranchno).HasColumnType("varchar(25)");
            builder.Property(e => e.taxrepbranchname).HasColumnType("varchar(255)");
            builder.Property(e => e.no).HasColumnType("varchar(10)");
            builder.Property(e => e.moo).HasColumnType("varchar(10)");
            builder.Property(e => e.floor).HasColumnType("varchar(10)");
            builder.Property(e => e.room).HasColumnType("varchar(10)");
            builder.Property(e => e.village).HasColumnType("varchar(255)");
            builder.Property(e => e.village2).HasColumnType("varchar(255)");
            builder.Property(e => e.building).HasColumnType("varchar(255)");
            builder.Property(e => e.building2).HasColumnType("varchar(255)");
            builder.Property(e => e.soi).HasColumnType("varchar(255)");
            builder.Property(e => e.soi2).HasColumnType("varchar(255)");
            builder.Property(e => e.yaek).HasColumnType("varchar(10)");
            builder.Property(e => e.road).HasColumnType("varchar(255)");
            builder.Property(e => e.road2).HasColumnType("varchar(255)");
            builder.Property(e => e.tambolcode).HasColumnType("varchar(25)");
            builder.Property(e => e.tambolname).HasColumnType("varchar(255)");
            builder.Property(e => e.tambolname2).HasColumnType("varchar(255)");
            builder.Property(e => e.amplurcode).HasColumnType("varchar(25)");
            builder.Property(e => e.amplurname).HasColumnType("varchar(255)");
            builder.Property(e => e.amplurname2).HasColumnType("varchar(255)");
            builder.Property(e => e.provincecode).HasColumnType("varchar(25)");
            builder.Property(e => e.provincename).HasColumnType("varchar(255)");
            builder.Property(e => e.provincename2).HasColumnType("varchar(25)");
            builder.Property(e => e.countrycode).HasColumnType("varchar(25)");
            builder.Property(e => e.countryname).HasColumnType("varchar(255)");
            builder.Property(e => e.countryname2).HasColumnType("varchar(255)");
            builder.Property(e => e.cipcode).HasColumnType("varchar(10)");
         

            //builder.HasOne(d => d.Company).WithMany(p => p.Accbooks).HasForeignKey(d => d.companyid).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
