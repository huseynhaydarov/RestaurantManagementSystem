using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;
using RMS.Infrastructure.Persistence.DataBases;


namespace RMS.Infrastructure.Persistence.Repositories;

public class ReservationTableRepository : BaseRepository<Table>, IReservationTableRepository
{
    public ReservationTableRepository(EFContext context) : base(context)
    {
    }
}