using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Entities;

namespace RMS.Infrastructure.Persistence.Configurations;

public class ReservationTableConfiguration : IEntityTypeConfiguration<Table>
{
    public void Configure(EntityTypeBuilder<Table> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Number).IsRequired();
        builder.Property(t => t.Capacity).IsRequired();
        builder.Property(t => t.Status).HasConversion<string>();
    }
}