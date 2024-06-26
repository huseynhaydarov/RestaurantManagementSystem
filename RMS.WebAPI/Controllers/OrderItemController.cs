﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.OrderItemsRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Application.Responses.OrderItemResponses;
using RMS.Application.Services;
using RMS.Domain.Entities;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderItemController(IBaseService<OrderItem> orderItemService, IMapper mapper) : ControllerBase
{
    [HttpPost(ApiEndpoints.OrderItem.Create)]
    public async Task<IActionResult> Create([FromBody] CreateOrderItemRequestModel request, CancellationToken token)
    {
        var orderItem = mapper.Map<OrderItem>(request);

        var response = await orderItemService.CreateAsync(orderItem, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.OrderItem.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var isOrderItemExist = await orderItemService.GetAsync(id, token);

        var response = mapper.Map<SingleOrderItemReponseModel>(isOrderItemExist);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpGet(ApiEndpoints.OrderItem.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var orderItems = await orderItemService.GetAllAsync(token);

        var response = new GetAllOrderItemReponseModel()
        {
            Items = mapper.Map<IEnumerable<SingleOrderItemReponseModel>>(orderItems)
        };

        return Ok(response);
    }

    [HttpPut(ApiEndpoints.OrderItem.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateOrderItemRequestModel? request,
    CancellationToken token)
    {
        if (request == null)
        {
            return BadRequest("Invalid request data.");
        }

        OrderItem orderItem = await orderItemService.GetAsync(id, token);

        orderItem.Count = request.Count;
        orderItem.Status = request.Status;

        await orderItemService.UpdateAsync(orderItem, token);

        var response = mapper.Map<SingleOrderItemReponseModel>(orderItem);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpDelete(ApiEndpoints.OrderItem.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await orderItemService.DeleteAsync(id, token);

        return response ? Ok() : NotFound($"Order Item with ID {id} not found.");
    }
}


