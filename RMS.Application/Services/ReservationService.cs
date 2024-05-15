using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class ReservationService(IBaseRepository<Reservation> reservationRepository)
{
    public async Task<Reservation> CreateAsync(Reservation reservation, CancellationToken token = default)
    {
        return await reservationRepository.CreateAsync(reservation, token);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var reservation = await reservationRepository.GetAsync(id);
        if (reservation == null)
        {
            return false;
        }
        return await reservationRepository.DeleteAsync(reservation, token);
    }

    public async Task<IEnumerable<Reservation>> GetAllAsync(CancellationToken token = default)
    {
        return await reservationRepository.GetAllAsync(token);
    }

    public async Task<Reservation> GetAsync(int id, CancellationToken token = default)
    {
        return await reservationRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Reservation reservation, CancellationToken token = default)
    {
        var isReservationExists = await reservationRepository.GetAsync(reservation.Id, token);

        if (isReservationExists == null)
        {
            return false;
        }
        return await reservationRepository.UpdateAsync(reservation, token);
    }
}
