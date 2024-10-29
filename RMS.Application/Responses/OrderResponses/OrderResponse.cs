namespace RMS.Application.Responses.OrderResponses;

public record OrderResponse
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public string? Location { get; set; }
    public decimal TotalPrice { get; set; }
    public int CustomerId { get; set; }
    public int TableId { get; set; }
}