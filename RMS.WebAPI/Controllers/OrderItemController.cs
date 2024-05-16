﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.MenuItemRequestModel;
using RMS.Application.Requests.OrderItemsRequests;


namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderItemController(IOrderItemService orderItemService) : ControllerBase
{
    [HttpPost(ApiEndpoints.OrderItem.Create)]
    public async Task<IActionResult> Create([FromBody] CreateOrderItemRequestModel request, CancellationToken token)
    {
        var response = await orderItemService.CreateAsync(request, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.OrderItem.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var response = await orderItemService.GetAsync(id, token);
        return Ok(response);
    }

    [HttpGet(ApiEndpoints.OrderItem.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var response = await orderItemService.GetAllAsync(token);
        return Ok(response);
    }

    [HttpPut(ApiEndpoints.OrderItem.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateOrderItemRequestModel request,
        CancellationToken token)
    {
        var response = await orderItemService.UpdateAsync(request, token);
        return Ok(response);
    }

    [HttpDelete(ApiEndpoints.OrderItem.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await orderItemService.DeleteAsync(id, token);
        return Ok(response);
    }
}