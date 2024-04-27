using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Responses.OrderItemResponses;

public record SingleOrderItemReponseModel
{
    public int Id { get; set; }
    public double Count { get; set; }
    public OrderStatus Status { get; set; }
    public int MenuItemId { get; set; }
}
