using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Requests.OrderItemsRequests;

public record CreateOrderItemRequestModel
{
    public double Count { get; set; }
    public OrderStatus Status { get; set; }
}
