using RMS.Domain.Entities;

namespace RMS.Application.Requests.MenuItemRequests;

public record GetAllMenuItemRequestModel
{
    public IEnumerable<MenuItem> Items { get; init; } = Enumerable.Empty<MenuItem>();
}