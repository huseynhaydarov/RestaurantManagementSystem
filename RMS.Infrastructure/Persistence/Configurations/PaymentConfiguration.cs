using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Entities;

namespace RMS.Infrastructure.Persistence.TablesConfiguration;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.PaymentDate).IsRequired();
        builder.Property(p => p.PaymentAmount).HasPrecision(18, 2).IsRequired();
        builder.Property(p => p.Type).HasConversion<string>().IsRequired();
        builder.Property(p => p.Status).HasConversion<string>().IsRequired();
        builder.HasOne(p => p.Order)
          .WithOne(o => o.Payment)
          .HasForeignKey<Payment>(p => p.OrderId).IsRequired();
    }
}

