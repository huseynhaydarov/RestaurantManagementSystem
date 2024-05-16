﻿using AutoMapper;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Exceptions;
using RMS.Application.Requests.MenuItemRequestModel;
using RMS.Application.Requests.OrderItemsRequests;
using RMS.Application.Responses.MenuItemResponses;
using RMS.Application.Responses.OrderItemResponses;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class OrderItemService(IOrderItemRepository orderItemRepository, IMapper mapper) : IOrderItemService
{
    public async Task<OrderItemResponse> CreateAsync(CreateOrderItemRequestModel request,
        CancellationToken token = default)
    {
        var orderItem = mapper.Map<OrderItem>(request);
        var response = await orderItemRepository.CreateAsync(orderItem, token);
        return mapper.Map<OrderItemResponse>(response);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var orderItem = await orderItemRepository.GetAsync(id, token);
        if (orderItem is null)
        {
            throw new NotFoundException(nameof(OrderItem), id);
        }

        return await orderItemRepository.DeleteAsync(orderItem, token);
    }

    public async Task<List<OrderItemResponse>> GetAllAsync(CancellationToken token = default)
    {

        var response = await orderItemRepository.GetAllAsync(token);
        return mapper.Map<List<OrderItemResponse>>(response);
    }

    public async Task<OrderItemResponse?> GetAsync(int id, CancellationToken token = default)
    {
        var response = await orderItemRepository.GetAsync(id, token);

        if (response is null)
        {
            throw new NotFoundException(nameof(OrderItem), id);
        }

        return mapper.Map<OrderItemResponse>(response);
    }

    public async Task<bool> UpdateAsync(UpdateOrderItemRequestModel request, CancellationToken token = default)
    {
        var orderItem = await orderItemRepository.GetAsync(request.Id, token);

        if (orderItem is null)
        {
            throw new NotFoundException(nameof(OrderItem), request.Id);
        }

        orderItem = mapper.Map<OrderItem>(request);
        return await orderItemRepository.UpdateAsync(orderItem, token);
    }
}