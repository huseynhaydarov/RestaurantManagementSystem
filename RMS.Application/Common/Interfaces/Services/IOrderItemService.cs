using RMS.Application.Requests.MenuItemRequestModel;
using RMS.Application.Requests.OrderItemsRequests;
using RMS.Application.Responses.MenuItemResponses;
using RMS.Application.Responses.OrderItemResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Common.Interfaces.Services
{
    public interface IOrderItemService
    {
     
        Task<OrderItemResponse?> GetAsync(int id, CancellationToken token = default);

        Task<List<OrderItemResponse>> GetAllAsync(CancellationToken token = default);

        Task<OrderItemResponse> CreateAsync(CreateOrderItemRequestModel request, CancellationToken token = default);

        Task<bool> UpdateAsync(UpdateOrderItemRequestModel request, CancellationToken token = default);

        Task<bool> DeleteAsync(int id, CancellationToken token = default);
    }
}

