using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichnessSoft.Entity.Model;


namespace RichnessSoft.Entity.Configuration
{
    public class PayTypeConfiguration : IEntityTypeConfiguration<PayType>
    {
        public void Configure(EntityTypeBuilder<PayType> builder)
        {
            builder.ToTable("paytype");
            builder.HasKey(m => m.id);
            builder.Property(e => e.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.name1).HasColumnType("varchar(150)").IsRequired();
            builder.Property(e => e.name2).HasColumnType("varchar(150)");
            builder.Property(e => e.isdeposit).HasColumnType("varchar(150)");
            builder.Property(e => e.iswithdraw).HasColumnType("varchar(150)");
            builder.Property(e => e.group).HasColumnType("varchar(150)");
            builder.Property(e => e.inout).HasColumnType("varchar(150)");
            builder.Property(e => e.active).HasColumnType("varchar(1)").HasDefaultValue("Y").HasComment("active");

            //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
