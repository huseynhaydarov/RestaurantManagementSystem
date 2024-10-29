using RMS.Domain.Enum;

namespace RMS.Application.Requests.OrderItemsRequests;

public record CreateOrderItemRequestModel
{
    public double Count { get; set; }
    public OrderStatus Status { get; set; }
    public int MenuItemId { get; set; }
}