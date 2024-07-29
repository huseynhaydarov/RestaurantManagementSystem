using RMS.Domain.Entities;

namespace RMS.Application.Requests.ReservationRequests;

public record GetAllReservationRequestModel
{
    public IEnumerable<Reservation> Items { get; init; } = Enumerable.Empty<Reservation>();
}
