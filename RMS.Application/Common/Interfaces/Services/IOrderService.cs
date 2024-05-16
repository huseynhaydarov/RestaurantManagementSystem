using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.OrderItemsRequests;
using RMS.Application.Requests.OrderRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Application.Responses.OrderResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
