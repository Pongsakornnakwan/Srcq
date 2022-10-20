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
    //internal class GLTrnRefConfiguration : IEntityTypeConfiguration<GLTrnRef>
    //{
    //    public void Configure(EntityTypeBuilder<GLTrnRef> builder)
    //    {
    //        builder.ToTable("GLTrnRef");
    //        builder.HasKey(m => m.id);
    //        builder.Property(e => e.doctype).HasColumnType("varchar(4)");
    //        builder.Property(e => e.gltrnhid).HasColumnType("varchar(25)");
    //        builder.Property(e => e.systype).HasColumnType("varchar(25)");
    //        builder.Property(e => e.docrefcode).HasColumnType("varchar(25)");
    //        builder.Property(e => e.docrefno).HasColumnType("varchar(25)");
    //        builder.Property(e => e.docrefcustcode).HasColumnType("varchar(25)");
    //        builder.Property(e => e.docrefvalueaddedtax).HasColumnType("varchar(1)");
    //        builder.Property(e => e.docrefvatcode).HasColumnType("varchar(25)");
    //        builder.Property(e => e.docrefvatrate).HasColumnType("decimal(18,2)");
    //        builder.Property(e => e.docrefbfvatamt).HasColumnType("decimal(18,2)");
    //        builder.Property(e => e.docrefvatamt).HasColumnType("decimal(18,2)");
    //        builder.Property(e => e.docrefnetamt).HasColumnType("decimal(18,2)");
    //        builder.Property(e => e.taxseq).HasColumnType("varchar(25)");
    //        builder.Property(e => e.taxnameonreport).HasColumnType("varchar(255)");
    //        builder.Property(e => e.taxid).HasColumnType("varchar(25)");
    //        builder.Property(e => e.taxbranchno).HasColumnType("varchar(25)");
    //        builder.Property(e => e.taxbranchname).HasColumnType("varchar(255)");
    //        builder.Property(e => e.taxrefund).HasColumnType("varchar(1)");
    //        builder.Property(e => e.taxrefundpercen).HasColumnType("decimal(18,2)");
    //        builder.Property(e => e.taxrefundamt).HasColumnType("decimal(18,2)");
    //        builder.Property(e => e.taxdue).HasColumnType("varchar(1)");


    //        //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
    //    }
    //}
}

