using RMS.Domain.Enum;

namespace RMS.Application.Requests.MenuItemRequests;

public record CreateMenuItemRequestModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public FoodCategory Category { get; set; }
}