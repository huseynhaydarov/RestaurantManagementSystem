using RMS.Application.Requests.ReservationRequests;
using RMS.Application.Responses.ReservationResponses;

namespace RMS.Application.Common.Interfaces.Services
{
    public interface IReservationService
    {
        Task<ReservationResponse?> GetAsync(int id, CancellationToken token = default);

        Task<List<ReservationResponse>> GetAllAsync(CancellationToken token = default);

        Task<ReservationResponse> CreateAsync(CreateReservationRequestModel request, CancellationToken token = default);

        Task<bool> UpdateAsync(UpdateReservationRequestModel request, CancellationToken token = default);

        Task<bool> DeleteAsync(int id, CancellationToken token = default);
    }
}
