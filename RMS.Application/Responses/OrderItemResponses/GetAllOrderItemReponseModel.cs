using RMS.Application.Responses.MenuItemResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Responses.OrderItemResponses;

public class GetAllOrderItemReponseModel
{
    public IEnumerable<SingleOrderItemReponseModel> Items { get; init; } = Enumerable.Empty<SingleOrderItemReponseModel>();
}
