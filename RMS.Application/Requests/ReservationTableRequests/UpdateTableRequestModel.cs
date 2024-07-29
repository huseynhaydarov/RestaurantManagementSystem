using RMS.Domain.Enum;
using System.Text.Json.Serialization;

namespace RMS.Application.Requests.TableRequests;

public record UpdateTableRequestModel
{
    [JsonIgnore]
    public int Id { get; set; }
    public int Number { get; set; }
    public int Capacity { get; set; }
    public TableStatus Status { get; set; }
}
