using RMS.Domain.Enum;
using System.Text.Json.Serialization;

namespace RMS.Application.Requests.MenuItemRequestModel;

public record UpdateMenuItemRequestModel
{
    [JsonIgnore]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public FoodCategory Category { get; set; }
}


