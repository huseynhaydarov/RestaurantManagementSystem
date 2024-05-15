using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class ReservationTableService(IBaseRepository<ReservationTable> reservationTableRepository)
{
    public async Task<ReservationTable> CreateAsync(ReservationTable reservationTable, CancellationToken token = default)
    {
        return await reservationTableRepository.CreateAsync(reservationTable, token);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var reservationTable = await reservationTableRepository.GetAsync(id);
        if (reservationTable == null)
        {
            return false;
        }
        return await reservationTableRepository.DeleteAsync(reservationTable, token);
    }

    public async Task<IEnumerable<ReservationTable>> GetAllAsync(CancellationToken token = default)
    {
        return await reservationTableRepository.GetAllAsync(token);
    }

    public async Task<ReservationTable> GetAsync(int id, CancellationToken token = default)
    {
        return await reservationTableRepository.GetAsync(id, token);
    }

    public async  Task<bool> UpdateAsync(ReservationTable reservationTable, CancellationToken token = default)
    {
        var isTableExist = await reservationTableRepository.GetAsync(reservationTable.Id, token);

        if (isTableExist == null)
        {
            return false;
        }
        return await reservationTableRepository.UpdateAsync(reservationTable, token);
    }
}
    