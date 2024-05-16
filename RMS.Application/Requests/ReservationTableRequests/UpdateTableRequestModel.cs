using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RMS.Application.Requests.TableRequests;

public record UpdateTableRequestModel
{
    [JsonIgnore]
    public int Id { get; set; } 
    public int Number { get; set; }
    public int Capacity { get; set; }
    public TableStatus Status { get; set; }
}
