using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.PaymentRequests;


namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentController(IPaymentService paymentService) : ControllerBase
{
    [HttpPost(ApiEndpoints.Payment.Create)]
    public async Task<IActionResult> Create([FromBody] CreatePaymentRequestModel request, CancellationToken token)
    {
        var response = await paymentService.CreateAsync(request, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.Payment.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var response = await paymentService.GetAsync(id, token);
        return Ok(response);
    }

    [HttpGet(ApiEndpoints.Payment.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var response = await paymentService.GetAllAsync(token);
        return Ok(response);
    }

    [HttpPut(ApiEndpoints.Payment.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePaymentRequestModel request,
        CancellationToken token)
    {
        var response = await paymentService.UpdateAsync(request, token);
        return Ok(response);
    }

    [HttpDelete(ApiEndpoints.Payment.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await paymentService.DeleteAsync(id, token);
        return Ok(response);
    }
}