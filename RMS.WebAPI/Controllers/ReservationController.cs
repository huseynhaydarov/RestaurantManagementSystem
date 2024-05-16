using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.ReservationRequests;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ReservationController(IReservationService reservationService) : ControllerBase
{
    [HttpPost(ApiEndpoints.Reservation.Create)]
    public async Task<IActionResult> Create([FromBody] CreateReservationRequestModel request, CancellationToken token)
    {
        var response = await reservationService.CreateAsync(request, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.Reservation.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var response = await reservationService.GetAsync(id, token);
        return Ok(response);
    }

    [HttpGet(ApiEndpoints.Reservation.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var response = await reservationService.GetAllAsync(token);
        return Ok(response);
    }

    [HttpPut(ApiEndpoints.Reservation.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateReservationRequestModel request,
        CancellationToken token)
    {
        var response = await reservationService.UpdateAsync(request, token);
        return Ok(response);
    }

    [HttpDelete(ApiEndpoints.Reservation.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await reservationService.DeleteAsync(id, token);
        return Ok(response);
    }
}