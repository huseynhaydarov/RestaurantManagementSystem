using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.MenuItemRequestModel;
using RMS.Application.Responses.MenuItemResponses;
using RMS.Domain.Entities;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MenuItemController(IMenuItemService menuItemService) : ControllerBase
{
    [HttpPost(ApiEndpoints.MenuItem.Create)]
    public async Task<IActionResult> Create([FromBody] CreateMenuItemRequestModel request, CancellationToken token)
    {
        var response = await menuItemService.CreateAsync(request, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }

    [HttpGet(ApiEndpoints.MenuItem.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var response = await menuItemService.GetAsync(id, token);
        return Ok(response);
    }

    [HttpGet(ApiEndpoints.MenuItem.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var response = await menuItemService.GetAllAsync(token);
        return Ok(response);
    }

    [HttpPut(ApiEndpoints.MenuItem.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateMenuItemRequestModel request,
        CancellationToken token)
    {
        var response = await menuItemService.UpdateAsync(request, token);
        return Ok(response);
    }

    [HttpDelete(ApiEndpoints.MenuItem.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await menuItemService.DeleteAsync(id, token);
        return Ok(response);
    }
}