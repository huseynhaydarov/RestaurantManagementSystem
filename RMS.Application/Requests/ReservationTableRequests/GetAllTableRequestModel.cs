using RMS.Domain.Entities;

namespace RMS.Application.Requests.ReservationTableRequests;

public record GetAllTableRequestModel
{
    public IEnumerable<Customer> Items { get; init; } = Enumerable.Empty<Customer>();
}