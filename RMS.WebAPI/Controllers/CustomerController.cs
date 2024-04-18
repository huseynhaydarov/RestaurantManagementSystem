using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Domain.Entities;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly I _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("id")]
        public OrderResponse GetById(int id)
        {
            return _orderService.Get(id);
        }

        [HttpPost]
        public void Add(CreateOrderRequest order)
        {
            _orderService.Add(order);
        }

        [HttpPut("id")]
        public void Update(int id, CreateOrderRequest order)
        {
            _orderService.Update(id, order);
        }

        [HttpDelete("id")]

        public void Delete(int id)
        {
            _orderService.Delete(id);
        }
    }
}


