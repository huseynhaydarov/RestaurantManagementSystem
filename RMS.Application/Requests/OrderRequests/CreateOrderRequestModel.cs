namespace RMS.Application.Requests.OrderRequests;

public record CreateOrderRequestModel
{
    public DateTime DateTime { get; set; }
    public string? Location { get; set; }
    public decimal TotalPrice { get; set; }
    public int CustomerId { get; set; }

}
