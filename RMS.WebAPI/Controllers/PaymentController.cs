﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.PaymentRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Application.Responses.PaymentResponses;
using RMS.Domain.Entities;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentController(IBaseService<Payment> paymentService, IMapper mapper) : ControllerBase
{
    [HttpPost(ApiEndpoints.Payment.Create)]
    public async Task<IActionResult> Create([FromBody] CreatePaymentRequestModel request, CancellationToken token)
    {
        var payment = mapper.Map<Payment>(request);

        var response = await paymentService.CreateAsync(payment, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.Payment.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var isPaymentaExist = await paymentService.GetAsync(id, token);

        var response = mapper.Map<SinglePaymentResponseModel>(isPaymentaExist);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpGet(ApiEndpoints.Payment.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var payments = await paymentService.GetAllAsync(token);

        var response = new GetAllPaymentResponseModel()
        {
            Items = mapper.Map<IEnumerable<SinglePaymentResponseModel>>(payments)
        };

        return Ok(response);
    }

    [HttpPut(ApiEndpoints.Payment.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePaymentRequestModel? request,
    CancellationToken token)
    {
        if (request == null)
        {
            return BadRequest("Invalid request data.");
        }

        Payment payment = await paymentService.GetAsync(id, token);

        payment.PaymentDate = request.PaymentDate;
        payment.Status = request.Status;
        payment.PaymentAmount = request.PaymentAmount;
        payment.Type = request.Type;
     

        await paymentService.UpdateAsync(payment, token);

        var response = mapper.Map<SinglePaymentResponseModel>(payment);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpDelete(ApiEndpoints.Payment.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await paymentService.DeleteAsync(id, token);

        return response ? Ok() : NotFound($"Payment with ID {id} not found.");
    }
}


