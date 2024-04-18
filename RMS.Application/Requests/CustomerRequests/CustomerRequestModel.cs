using RMS.Domain.Entities;

namespace RMS.Application.Requests.CustomerRequests;

public class CustomerRequestModel
{
    public IEnumerable<Customer> Items { get; set; } = Enumerable.Empty<Customer>();
}
