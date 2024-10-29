using RMS.Application.Requests.ReservationTableRequests;
using RMS.Application.Responses.ReservationTableResponses;

namespace RMS.Application.Common.Interfaces.Services;

public interface IReservationTableService
{
    Task<ReservationTableResponse?> GetAsync(int id, CancellationToken token = default);

    Task<List<ReservationTableResponse>> GetAllAsync(CancellationToken token = default);

    Task<ReservationTableResponse> CreateAsync(CreateTableRequestModel request, CancellationToken token = default);

    Task<bool> UpdateAsync(UpdateTableRequestModel request, CancellationToken token = default);

    Task<bool> DeleteAsync(int id, CancellationToken token = default);
}