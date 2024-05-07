using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Infrastructure.Persistence.DataBases;
using RMS.Application.Common.Interfaces;
using RMS.Domain.Entities;


namespace RMS.Infrastructure.Persistence.Repositories;

public class ReservationTableRepository : BaseRepository<ReservationTable>, IReservationTableRepository
{
    public ReservationTableRepository(EFContext context) : base(context)
    {
    }
}