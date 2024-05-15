// using AutoMapper;
// using Microsoft.AspNetCore.Mvc;
// using RMS.Application.Common.Interfaces;
// using RMS.Application.Requests.CustomerRequests;
// using RMS.Application.Requests.TableRequests;
// using RMS.Application.Responses.CustomerResponses;
// using RMS.Application.Responses.TableResponses;
// using RMS.Domain.Entities;
//
// namespace RMS.WebAPI.Controllers;
//
//
// [ApiController]
// [Route("[controller]")]
// public class ReservationTableController(IBaseService<ReservationTable> reservationTableService, IMapper mapper) : ControllerBase
// {
//     private readonly IBaseService<ReservationTable> _reservationTableService = reservationTableService;
//     private readonly IMapper _mapper = mapper;
//
//     [HttpPost(ApiEndpoints.ReservationTable.Create)]
//     public async Task<IActionResult> Create([FromBody] CreateReservationTableRequestModel request, CancellationToken token)
//     {
//         var reservationTable = _mapper.Map<ReservationTable>(request);
//
//         var response = await _reservationTableService.CreateAsync(reservationTable, token);
//         return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
//     }
//
//     [HttpGet(ApiEndpoints.ReservationTable.Get)]
//     public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
//     {
//         var isTableExist = await _reservationTableService.GetAsync(id, token);
//
//         var response = _mapper.Map<SingleReservationTableResponseModel>(isTableExist);
//
//         return response == null ? NotFound() : Ok(response);
//     }
//
//     [HttpGet(ApiEndpoints.ReservationTable.GetAll)]
//     public async Task<IActionResult> GetAll(CancellationToken token)
//     {
//         var reservationTables = await _reservationTableService.GetAllAsync(token);
//
//         var response = new GetAllReservationTableResponseModel()
//         {
//             Items = _mapper.Map<IEnumerable<SingleReservationTableResponseModel>>(reservationTables)
//         };
//
//         return Ok(response);
//     }
//
//     [HttpPut(ApiEndpoints.ReservationTable.Update)]
//     public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateReservationTableRequestModel? request,
//     CancellationToken token)
//     {
//         if (request == null)
//         {
//             return BadRequest("Invalid request data.");
//         }
//
//         ReservationTable reservationTable = await _reservationTableService.GetAsync(id, token);
//
//         reservationTable.Number = request.Number;
//         reservationTable.Status = request.Status;
//         reservationTable.Capacity = request.Capacity;
//
//         await _reservationTableService.UpdateAsync(reservationTable, token);
//
//         var response = mapper.Map<SingleReservationTableResponseModel>(reservationTable);
//
//         return response == null ? NotFound() : Ok(response);
//     }
//
//     [HttpDelete(ApiEndpoints.ReservationTable.Delete)]
//     public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
//     {
//         var response = await _reservationTableService.DeleteAsync(id, token);
//
//         return response ? Ok() : NotFound($"Table with ID {id} not found.");
//     }
// }
//
//
//
