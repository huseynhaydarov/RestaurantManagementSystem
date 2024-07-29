using AutoMapper;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Exceptions;
using RMS.Application.Requests.OrderRequests;
using RMS.Application.Responses.OrderResponses;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class OrderService(IOrderRepository orderRepository, IMapper mapper) : IOrderService
{
    public async Task<OrderResponse> CreateAsync(CreateOrderRequestModel request, 
        CancellationToken token = default)
    {
        var order = mapper.Map<Order>(request);
        var response = await orderRepository.CreateAsync(order, token);
        return mapper.Map<OrderResponse>(response);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var order = await orderRepository.GetAsync(id, token);

        if(order is null)
        {
            throw new NotFoundException(nameof(order), id);
        }
        return await orderRepository.DeleteAsync(order, token);
    }

    public async Task<List<OrderResponse>> GetAllAsync(CancellationToken token = default)
    {
        var response = await orderRepository.GetAllAsync(token);
        return mapper.Map<List<OrderResponse>>(response);
    }

    public async Task<OrderResponse?> GetAsync(int id, CancellationToken token = default)
    {
        var response = await orderRepository.GetAsync(id, token);

        if(response is null)
        {
            throw new NotFoundException(nameof(Order), id);
        }

        return mapper.Map<OrderResponse>(response);
    }

    public async Task<bool> UpdateAsync(UpdateOrderRequestModel request, CancellationToken token = default)
    {
        var order = await orderRepository.GetAsync(request.Id, token);

        if (order is null)
        {
            throw new NotFoundException(nameof(Order), request.Id);
        }

        order = mapper.Map<Order>(request);
        return await orderRepository.UpdateAsync(order, token);
    }
}
