using RMS.Domain.Enum;

namespace RMS.Application.Requests.TableRequests;

public record CreateTableRequestModel
{
    public int Number { get; set; }
    public int Capacity { get; set; }
    public TableStatus Status { get; set; }
}


