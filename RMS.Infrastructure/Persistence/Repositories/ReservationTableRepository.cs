using RMS.Application.Common.Interfaces.Repositories;
using RMS.Infrastructure.Persistence.DataBases;

using RMS.Domain.Entities;


namespace RMS.Infrastructure.Persistence.Repositories;

public class ReservationTableRepository : BaseRepository<Table>, IReservationTableRepository
{
    public ReservationTableRepository(EFContext context) : base(context)
    {
    }
}