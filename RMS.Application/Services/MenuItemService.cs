using AutoMapper;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Exceptions;
using RMS.Application.Requests.MenuItemRequestModel;
using RMS.Application.Responses.MenuItemResponses;
using RMS.Domain.Entities;

public class MenuItemService(IMenuItemRepository menuItemRepository, IMapper mapper) : IMenuItemService
{
    public async Task<MenuItemResponse> CreateAsync(CreateMenuItemRequestModel request,
        CancellationToken token = default)
    {
        var menuItem = mapper.Map<MenuItem>(request);
        var response = await menuItemRepository.CreateAsync(menuItem, token);
        return mapper.Map<MenuItemResponse>(response);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var menuItem = await menuItemRepository.GetAsync(id, token);
        if (menuItem is null)
        {
            throw new NotFoundException(nameof(Customer), id);
        }

        return await menuItemRepository.DeleteAsync(menuItem, token);
    }

    public async Task<List<MenuItemResponse>> GetAllAsync(CancellationToken token = default)
    {

        var response = await menuItemRepository.GetAllAsync(token);
        return mapper.Map<List<MenuItemResponse>>(response);
    }

    public async Task<MenuItemResponse?> GetAsync(int id, CancellationToken token = default)
    {
        var response = await menuItemRepository.GetAsync(id, token);

        if (response is null)
        {
            throw new NotFoundException(nameof(MenuItem), id);
        }

        return mapper.Map<MenuItemResponse>(response);
    }

    public async Task<bool> UpdateAsync(UpdateMenuItemRequestModel request, CancellationToken token = default)
    {
        var menuItem = await menuItemRepository.GetAsync(request.Id, token);

        if (menuItem is null)
        {
            throw new NotFoundException(nameof(MenuItem), request.Id);
        }

        menuItem = mapper.Map<MenuItem>(request);
        return await menuItemRepository.UpdateAsync(menuItem, token);
    }
}