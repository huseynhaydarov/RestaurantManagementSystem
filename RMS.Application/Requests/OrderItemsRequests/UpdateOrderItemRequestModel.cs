using RMS.Domain.Enum;
using System.Text.Json.Serialization;

namespace RMS.Application.Requests.OrderItemsRequests;

public record UpdateOrderItemRequestModel
{
    [JsonIgnore]
    public int Id { get; set; }
    public double Count { get; set; }
    public OrderStatus Status { get; set; }
    public int MenuItemId { get; set; }
}
