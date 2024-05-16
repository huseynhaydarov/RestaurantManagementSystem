﻿using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Requests.OrderRequests;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class OrderController(IOrderService orderService) : ControllerBase
{
    [HttpPost(ApiEndpoints.Order.Create)]
    public async Task<IActionResult> Create([FromBody] CreateOrderRequestModel request, CancellationToken token)
    {
        var response = await orderService.CreateAsync(request, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.Order.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var response = await orderService.GetAsync(id, token);
        return Ok(response);
    }

    [HttpGet(ApiEndpoints.Order.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var response = await orderService.GetAllAsync(token);
        return Ok(response);
    }

    [HttpPut(ApiEndpoints.Order.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateOrderRequestModel request,
    CancellationToken token)
    {
        var response = await orderService.UpdateAsync(request, token);
        return Ok(response);
    }

    [HttpDelete(ApiEndpoints.Order.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await orderService.DeleteAsync(id, token);
        return Ok(response);
    }
}
