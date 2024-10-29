using RMS.Domain.Entities;

namespace RMS.Application.Requests.OrderItemsRequests;

public record GetAllOrderItemRequestModel
{
    public IEnumerable<OrderItem> Items { get; init; } = Enumerable.Empty<OrderItem>();
}