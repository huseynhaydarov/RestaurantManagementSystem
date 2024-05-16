using RMS.Domain.Enum;

namespace RMS.Application.Responses.OrderItemResponses;

public record OrderItemResponse
{
    public int Id { get; set; }
    public double Count { get; set; }
    public OrderStatus Status { get; set; }
    public int MenuItemId { get; set; }
}
