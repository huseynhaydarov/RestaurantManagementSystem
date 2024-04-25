using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class ReservationTableService(IBaseRepository<ReservationTable> reservationTableRepository) : IBaseService<ReservationTable>
{
    private readonly IBaseRepository<ReservationTable> _reservationTableRepository = reservationTableRepository;
    public async Task<ReservationTable> CreateAsync(ReservationTable reservationTable, CancellationToken token = default)
    {
        return await _reservationTableRepository.CreateAsync(reservationTable, token);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var reservationTable = await _reservationTableRepository.GetAsync(id);
        if (reservationTable == null)
        {
            return false;
        }
        return await _reservationTableRepository.DeleteAsync(reservationTable, token);
    }

    public async Task<IEnumerable<ReservationTable>> GetAllAsync(CancellationToken token = default)
    {
        return await _reservationTableRepository.GetAllAsync(token);
    }

    public async Task<ReservationTable> GetAsync(int id, CancellationToken token = default)
    {
        return await _reservationTableRepository.GetAsync(id, token);
    }

    public async  Task<bool> UpdateAsync(ReservationTable reservationTable, CancellationToken token = default)
    {
        var isTableExist = await _reservationTableRepository.GetAsync(reservationTable.Id, token);

        if (isTableExist == null)
        {
            return false;
        }
        return await _reservationTableRepository.UpdateAsync(reservationTable, token);
    }
}
    