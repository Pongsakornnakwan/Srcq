using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Entity.Configuration
{
    public class ProductShelfCinfiguration : IEntityTypeConfiguration<ProductShelf>
    {
        public void Configure(EntityTypeBuilder<ProductShelf> builder)
        {
            builder.ToTable("productshelf");
            builder.HasKey(m => m.id);
            builder.Property(e => e.width).HasColumnType("decimal(18,2)");
            builder.Property(e => e.length).HasColumnType("decimal(18,2)");
            builder.Property(e => e.height).HasColumnType("decimal(18,2)");

            //builder.HasOne(p => p.Company).WithMany(p => p.Designs).HasForeignKey(e => e.companyid).OnDelete(DeleteBehavior.Restrict);
        }
    }
}