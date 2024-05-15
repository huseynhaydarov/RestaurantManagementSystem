// using AutoMapper;
// using Microsoft.AspNetCore.Mvc;
// using RMS.Application.Common.Interfaces;
// using RMS.Application.Requests.CustomerRequests;
// using RMS.Application.Requests.MenuItemRequestModel;
// using RMS.Application.Responses.CustomerResponses;
// using RMS.Application.Responses.MenuItemResponses;
// using RMS.Application.Services;
// using RMS.Domain.Entities;
//
// namespace RMS.WebAPI.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class MenuItemController(IBaseService<MenuItem> menuItemService, IMapper mapper) : ControllerBase
//     {
//         private readonly IBaseService<MenuItem> _menuItemService = menuItemService;
//         private readonly IMapper _mapper = mapper;
//
//         [HttpPost(ApiEndpoints.MenuItem.Create)]
//         public async Task<IActionResult> Create([FromBody] CreateMenuItemRequestModel request, CancellationToken token)
//         {
//             var menuItem = _mapper.Map<MenuItem>(request);
//
//             var response = await _menuItemService.CreateAsync(menuItem, token);
//             return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
//         }
//
//         [HttpGet(ApiEndpoints.MenuItem.Get)]
//         public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
//         {
//             var isMenuItemExist = await _menuItemService.GetAsync(id, token);
//
//             var response = _mapper.Map<SingleMenuItemResponseModel>(isMenuItemExist);
//
//             return response == null ? NotFound() : Ok(response);
//         }
//
//         [HttpGet(ApiEndpoints.MenuItem.GetAll)]
//         public async Task<IActionResult> GetAll(CancellationToken token)
//         {
//             var menuItems = await _menuItemService.GetAllAsync(token);
//
//             var response = new GetAllMenuItemResponseModel()
//             {
//                 Items = _mapper.Map<IEnumerable<SingleMenuItemResponseModel>>(menuItems)
//             };
//
//             return Ok(response);
//         }
//
//         [HttpPut(ApiEndpoints.MenuItem.Update)]
//         public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateMenuItemRequestModel? request,
//     CancellationToken token)
//         {
//             if (request == null)
//             {
//                 return BadRequest("Invalid request data.");
//             }
//
//             MenuItem menuItem = await _menuItemService.GetAsync(id, token);
//
//             menuItem.Category = request.Category;
//             menuItem.Description = request.Description;
//             menuItem.Name = request.Name;
//             menuItem.Price = request.Price;
//
//             await _menuItemService.UpdateAsync(menuItem, token);
//
//             var response = mapper.Map<SingleMenuItemResponseModel>(menuItem);
//
//             return response == null ? NotFound() : Ok(response);
//         }
//
//         [HttpDelete(ApiEndpoints.MenuItem.Delete)]
//         public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
//         {
//             var response = await _menuItemService.DeleteAsync(id, token);
//
//             return response ? Ok() : NotFound($"MenuItem with ID {id} not found.");
//         }
//     }
// }
//
//
//     
//
