namespace RMS.Application.Requests.ReservationRequests;

public record CreateReservationRequestModel
{
    public DateTime Date { get; set; }
    public int NumberOfGuests { get; set; }
    public int CustomerId { get; set; }
    public int TableId { get; set; }
}
