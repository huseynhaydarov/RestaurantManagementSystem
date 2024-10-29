using System.Text.Json.Serialization;
using RMS.Domain.Enum;

namespace RMS.Application.Requests.ReservationTableRequests;

public record UpdateTableRequestModel
{
    [JsonIgnore] public int Id { get; set; }

    public int Number { get; set; }
    public int Capacity { get; set; }
    public TableStatus Status { get; set; }
}