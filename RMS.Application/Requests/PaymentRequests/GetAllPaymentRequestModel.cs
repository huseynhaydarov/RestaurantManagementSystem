using RMS.Domain.Entities;
using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Requests.PaymentRequests;

public record GetAllPaymentRequestModel
{
    public IEnumerable<Payment> Items { get; init; } = Enumerable.Empty<Payment>();
}
