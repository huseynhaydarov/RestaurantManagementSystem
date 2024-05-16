using RMS.Domain.Enum;

namespace RMS.Application.Responses.PaymentResponses;

public record PaymentResponse
{
    public int Id { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal PaymentAmount { get; set; }
    public PaymentType Type { get; set; }
    public PaymentStatus Status { get; set; }
    public int OrderId { get; set; }
}

