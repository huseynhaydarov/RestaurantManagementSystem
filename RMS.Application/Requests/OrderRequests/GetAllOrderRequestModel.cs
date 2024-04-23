using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Requests.OrderRequests;

public record GetAllOrderRequestModel
{
    public IEnumerable<Order> Items { get; init; } = Enumerable.Empty<Order>();
}
