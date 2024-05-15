using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.ReservationRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Application.Responses.ReservationResponses;
using RMS.Domain.Entities;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ReservationController(IBaseService<Reservation> reservationService, IMapper mapper) : ControllerBase
{
    [HttpPost(ApiEndpoints.Reservation.Create)]
    public async Task<IActionResult> Create([FromBody] CreateReservationRequestModel request, CancellationToken token)
    {
        var reservation = mapper.Map<Reservation>(request);

        var response = await reservationService.CreateAsync(reservation, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.Reservation.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var isReservationExist = await reservationService.GetAsync(id, token);

        var response = mapper.Map<SingleReservationResponseModel>(isReservationExist);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpGet(ApiEndpoints.Reservation.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var reservations = await reservationService.GetAllAsync(token);

        var response = new GetAllReservationResponseModel()
        {
            Items = mapper.Map<IEnumerable<SingleReservationResponseModel>>(reservations)
        };

        return Ok(response);
    }

    [HttpPut(ApiEndpoints.Reservation.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateReservationRequestModel? request,
    CancellationToken token)
    {
        if (request == null)
        {
            return BadRequest("Invalid request data.");
        }

        Reservation reservation = await reservationService.GetAsync(id, token);

        reservation.NumberOfGuests = request.NumberOfGuests;
        reservation.ReservedDate = request.ReservedDate;
        reservation.ReservationTableId = request.ReservationTableId;
        reservation.CustomerId = request.ReservationTableId;

        await reservationService.UpdateAsync(reservation, token);

        var response = mapper.Map<SingleReservationResponseModel>(reservation);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpDelete(ApiEndpoints.Reservation.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await reservationService.DeleteAsync(id, token);

        return response ? Ok() : NotFound($"Reservation with ID {id} not found.");
    }
}


