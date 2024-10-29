using RMS.Domain.Entities;

namespace RMS.Application.Requests.PaymentRequests;

public record GetAllPaymentRequestModel
{
    public IEnumerable<Payment> Items { get; init; } = Enumerable.Empty<Payment>();
}