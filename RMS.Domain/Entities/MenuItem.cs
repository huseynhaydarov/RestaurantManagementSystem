using RMS.Domain.Abstract;
using RMS.Domain.Enum;

namespace RMS.Domain.Entities;

public class MenuItem : EntityBase
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public FoodCategory Category { get; set; }
    public ICollection<OrderItem>? Items { get; set; }
}
