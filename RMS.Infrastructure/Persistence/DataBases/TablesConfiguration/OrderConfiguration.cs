using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Entities;


namespace RMS.Infrastructure.Persistence.DataBases.TablesConfiguration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);
        builder.Property(o => o.OrderTime).IsRequired();
        builder.Property(o => o.Location).HasMaxLength(100).IsRequired();
        builder.Property(o => o.TotalPrice).HasPrecision(18, 2).IsRequired();
        builder.HasOne(o => o.Customer)
            .WithMany(o => o.Orders)
            .HasForeignKey(o => o.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(o => o.Type).HasConversion<string>();
    }
}
