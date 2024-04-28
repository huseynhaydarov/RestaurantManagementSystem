using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Persistence.DataBases.TablesConfiguration;

public class ReservationTableConfiguration : IEntityTypeConfiguration<ReservationTable>
{
    public void Configure(EntityTypeBuilder<ReservationTable> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Number).IsRequired();
        builder.Property(t => t.Capacity).IsRequired();
        builder.Property(t => t.Status).HasConversion<string>();
    }
}
