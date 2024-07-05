using RMS.Domain.Enum;

namespace RMS.Application.Responses.MenuItemResponses;

public record MenuItemResponse
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public FoodCategory Category { get; set; }
}
