using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Persistence.TablesConfiguration
{
    public class ReservationConfiguration : IEntityTypeConfiguration<ReservationConfiguration>
    {
        public void Configure(EntityTypeBuilder<ReservationConfiguration> builder)
        {
            throw new NotImplementedException();
        }
    }
}
