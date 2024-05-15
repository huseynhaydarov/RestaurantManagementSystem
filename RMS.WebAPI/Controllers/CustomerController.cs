using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Domain.Entities;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController(IBaseService<Customer> customerService, IMapper mapper) : ControllerBase
{
    [HttpPost(ApiEndpoints.Customer.Create)]
    public async Task<IActionResult> Create([FromBody] CreateCustomerRequestModel request, CancellationToken token)
    {
        var customer = mapper.Map<Customer>(request);

        var response = await customerService.CreateAsync(customer, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.Customer.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var isCustomerExist = await customerService.GetAsync(id, token);

        var response = mapper.Map<SingleCustomerResponseModel>(isCustomerExist);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpGet(ApiEndpoints.Customer.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var customers = await customerService.GetAllAsync(token);

        var response = new GetAllCustomerResponseModel()
        {
            Items = mapper.Map<IEnumerable<SingleCustomerResponseModel>>(customers)
        };

        return Ok(response);
    }

    [HttpPut(ApiEndpoints.Customer.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCustomerRequestModel? request,
    CancellationToken token)
    {
        if (request == null)
        {
            return BadRequest("Invalid request data.");
        }

        Customer customer = await customerService.GetAsync(id, token);

        customer.Email = request.Email;
        customer.Address = request.Address;
        customer.PhoneNumber = request.PhoneNumber;
        customer.FullName = request.FullName;
        
        await customerService.UpdateAsync(customer, token);

        var response = mapper.Map<SingleCustomerResponseModel>(customer);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpDelete(ApiEndpoints.Customer.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await customerService.DeleteAsync(id, token);

        return response ? Ok() : NotFound($"Customer with ID {id} not found.");
    }
}


