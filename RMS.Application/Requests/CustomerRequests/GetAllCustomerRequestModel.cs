using RMS.Domain.Entities;

namespace RMS.Application.Requests.CustomerRequests;

public record GetAllCustomerRequestModel
{
    public IEnumerable<Customer> Items { get; init; } = Enumerable.Empty<Customer>();
}

