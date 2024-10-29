namespace RMS.Application.Requests.OrderRequests;

public record UpdateOrderRequestModel
{
    public int Id { get; set; }
    public DateTime OrderTime { get; set; }
    public string? Location { get; set; }
    public decimal TotalPrice { get; set; }
    public int CustomerId { get; set; }
}