namespace RMS.Application.Responses.ReservationResponses;

public record ReservationResponse
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int NumberOfGuests { get; set; }
    public int CustomerId { get; set; }
    public int TableId { get; set; }
}