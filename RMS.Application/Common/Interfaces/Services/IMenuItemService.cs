using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.MenuItemRequestModel;
using RMS.Application.Responses.CustomerResponses;
using RMS.Application.Responses.MenuItemResponses;

namespace RMS.Application.Common.Interfaces.Services
{
    public interface IMenuItemService
    {
        Task<MenuItemResponse?> GetAsync(int id, CancellationToken token = default);

        Task<List<MenuItemResponse>> GetAllAsync(CancellationToken token = default);

        Task<MenuItemResponse> CreateAsync(CreateMenuItemRequestModel request, CancellationToken token = default);

        Task<bool> UpdateAsync(UpdateMenuItemRequestModel request, CancellationToken token = default);

        Task<bool> DeleteAsync(int id, CancellationToken token = default);
    }
}
