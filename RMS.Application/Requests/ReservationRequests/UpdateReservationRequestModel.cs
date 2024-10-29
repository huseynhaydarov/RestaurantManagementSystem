using System.Text.Json.Serialization;

namespace RMS.Application.Requests.ReservationRequests;

public record UpdateReservationRequestModel
{
    [JsonIgnore] public int Id { get; set; }

    public DateTime ReservedDate { get; set; }
    public int NumberOfGuests { get; set; }
    public int TableleId { get; set; }
}