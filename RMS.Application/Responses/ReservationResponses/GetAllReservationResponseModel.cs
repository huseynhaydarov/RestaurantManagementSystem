using RMS.Application.Responses.PaymentResponses;
using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Responses.ReservationResponses;

public record GetAllReservationResponseModel
{
    public IEnumerable<SingleReservationResponseModel> Items { get; init; } = Enumerable.Empty<SingleReservationResponseModel>();
}
