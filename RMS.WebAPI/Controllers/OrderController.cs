using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.OrderItemsRequests;
using RMS.Application.Requests.OrderRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Application.Responses.OrderResponses;
using RMS.Application.Services;
using RMS.Domain.Entities;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class OrderController(IBaseService<Order> orderService, IMapper mapper) : ControllerBase
{
    private readonly IBaseService<Order> _orderService = orderService;
    private readonly IMapper _mapper = mapper;

    [HttpPost(ApiEndpoints.Order.Create)]
    public async Task<IActionResult> Create([FromBody] CreateOrderRequestModel request, CancellationToken token)
    {
        var order = _mapper.Map<Order>(request);

        var response = await _orderService.CreateAsync(order, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.Order.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var isOrderExist = await _orderService.GetAsync(id, token);

        var response = _mapper.Map<SingleOrderResponseModel>(isOrderExist);
        return response == null ? NotFound() : Ok(response);
    }

    [HttpGet(ApiEndpoints.Order.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var orders = await _orderService.GetAllAsync(token);
        var response = new GetAllOrderResponseModel()
        {
            Items = _mapper.Map<IEnumerable<SingleOrderResponseModel>>(orders)
        };
        return Ok(response);
    }

    [HttpPut(ApiEndpoints.Order.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateOrderRequestModel? request,
    CancellationToken token)
    {
        if (request == null)
        {
            return BadRequest("Invalid request data.");
        }

        Order order = await _orderService.GetAsync(id, token);

        order.Location = request.Location;
        order.TotalPrice = request.TotalPrice;
        order.OrderTime = request.OrderTime;
        order.CustomerId = request.CustomerId;
       
        await _orderService.UpdateAsync(order, token);

        var response = mapper.Map<SingleOrderResponseModel>(order);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpDelete(ApiEndpoints.Order.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await _orderService.DeleteAsync(id, token);
        return response ? Ok() : NotFound($"Order with ID {id} not found"); ;
    }
}
