using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Requests.ReservationRequests;
using RMS.Application.Requests.TableRequests;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ReservationTableController(IReservationTableService reservationTableService) : ControllerBase
{
    [HttpPost(ApiEndpoints.ReservationTable.Create)]
    public async Task<IActionResult> Create([FromBody] CreateTableRequestModel request, CancellationToken token)
    {
        var response = await reservationTableService.CreateAsync(request, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.ReservationTable.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var response = await reservationTableService.GetAsync(id, token);
        return Ok(response);
    }

    [HttpGet(ApiEndpoints.ReservationTable.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var response = await reservationTableService.GetAllAsync(token);
        return Ok(response);
    }

    [HttpPut(ApiEndpoints.ReservationTable.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateTableRequestModel request,
        CancellationToken token)
    {
        var response = await reservationTableService.UpdateAsync(request, token);
        return Ok(response);
    }

    [HttpDelete(ApiEndpoints.ReservationTable.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await reservationTableService.DeleteAsync(id, token);
        return Ok(response);
    }
}
