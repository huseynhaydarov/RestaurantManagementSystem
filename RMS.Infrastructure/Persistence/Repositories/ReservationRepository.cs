using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;
using RMS.Infrastructure.Persistence.DataBases;

namespace RMS.Infrastructure.Persistence.Repositories;

public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
{
    public ReservationRepository(EFContext context) : base(context)
    {
    }
}
