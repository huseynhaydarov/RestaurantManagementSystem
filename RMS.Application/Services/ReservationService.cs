using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces;
using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services;

public class ReservationService(IBaseRepository<Reservation> reservationRepository) : IBaseService<Reservation>
{
    private readonly IBaseRepository<Reservation> _reservationRepository = reservationRepository;

    public async Task<Reservation> CreateAsync(Reservation reservation, CancellationToken token = default)
    {
        return await _reservationRepository.CreateAsync(reservation, token);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var reservation = await _reservationRepository.GetAsync(id);
        if (reservation == null)
        {
            return false;
        }
        return await _reservationRepository.DeleteAsync(reservation, token);
    }

    public async Task<IEnumerable<Reservation>> GetAllAsync(CancellationToken token = default)
    {
        return await _reservationRepository.GetAllAsync(token);
    }

    public async Task<Reservation> GetAsync(int id, CancellationToken token = default)
    {
        return await _reservationRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Reservation reservation, CancellationToken token = default)
    {
        var isReservationExists = await _reservationRepository.GetAsync(reservation.Id, token);

        if (isReservationExists == null)
        {
            return false;
        }
        return await _reservationRepository.UpdateAsync(reservation, token);
    }
}
