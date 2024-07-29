using RMS.Application.Requests.OrderRequests;
using RMS.Application.Responses.OrderResponses;

namespace RMS.Application.Common.Interfaces.Services
{
    public interface IOrderService
    {
        Task<OrderResponse?> GetAsync(int id, CancellationToken token = default);

        Task<List<OrderResponse>> GetAllAsync(CancellationToken token = default);

        Task<OrderResponse> CreateAsync(CreateOrderRequestModel request, CancellationToken token = default);

        Task<bool> UpdateAsync(UpdateOrderRequestModel request, CancellationToken token = default);

        Task<bool> DeleteAsync(int id, CancellationToken token = default);
    }
}
