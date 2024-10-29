using RMS.Domain.Entities;

namespace RMS.Application.Requests.OrderRequests;

public record GetAllOrderRequestModel
{
    public IEnumerable<Order> Items { get; init; } = Enumerable.Empty<Order>();
}