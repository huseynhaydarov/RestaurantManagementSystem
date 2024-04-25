using RMS.Domain.Entities;
using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RMS.Application.Requests.OrderItemsRequests;

public record UpdateOrderItemRequestModel
{
    [JsonIgnore]
    public int Id { get; set; } 
    public double Count { get; set; }
    public OrderStatus Status { get; set; }
}
