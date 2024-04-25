using RMS.Application.Responses.OrderItemResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Responses.PaymentResponses;

public record GetAllPaymentResponseModel
{
    public IEnumerable<SinglePaymentResponseModel> Items { get; init; } = Enumerable.Empty<SinglePaymentResponseModel>();
}
