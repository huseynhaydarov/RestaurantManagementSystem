using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Requests.ReservationRequests;

public record GetAllReservationRequestModel
{
    public IEnumerable<Reservation> Items { get; init; } = Enumerable.Empty<Reservation>();
}
