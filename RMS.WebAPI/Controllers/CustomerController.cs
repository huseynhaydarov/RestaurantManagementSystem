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
    private readonly IBaseService<Customer> _customerService;
    private readonly IMapper _mapper;

    public CustomerController(IBaseService<Customer> customerService, IMapper mapper)
    {
        _customerService = customerService;
        mapper = _mapper;
    }

    [HttpPost(ApiEndpoints.Customer.Create)]
    public async Task<IActionResult> Create([FromBody] CreateCustomerRequestModel request, CancellationToken token)
    {
        var customer = _mapper.Map<Customer>(request);

        var response = await _customerService.CreateAsync(customer, token);
        return CreatedAtAction(nameof(Get), new { Id = response.Id }, response);
    }
    [HttpGet(ApiEndpoints.Customer.Get)]
    public async Task<IActionResult> Get([FromRoute] int Id, CancellationToken token) 
    {
        var isCustomerExist = await _customerService.GetAsync(Id);
        if (isCustomerExist == null)
        {
            return NotFound();
        }
        var response = _mapper.Map<CustomerResponseModel>(isCustomerExist);
        return  response == null? NotFound() : Ok(response);
    }

    [HttpGet(ApiEndpoints.Customer.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var buildings = await _customerService.GetAllAsync(token);

        var response = new CustomerResponseModel()
        {
          
        };

        return Ok(response);
    }

    [HttpPut(ApiEndpoints.Customer.Update)]
    public async Task<IActionResult> Update([FromRoute] int Id, [FromBody] UpdateCustomerRequestModel request, CancellationToken token)
    {
        if (request == null)
        {
            return BadRequest("Invalid request data.");
        }

        Customer building = _mapper.Map<Customer>(request);

        await _customerService.UpdateAsync(building, token);

        var response = _mapper.Map<CustomerRequestModel>(building);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpDelete(ApiEndpoints.Customer.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int Id, CancellationToken token)
    {
        var response = await _customerService.DeleteAsync(Id, token);

        return response ? Ok() : NotFound($"Customer with ID {Id} not found.");
    }
}   


