using RMS.Application.Responses.CustomerResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Responses.OrderResponses;

public record GetAllOrderResponseModel
{
    public IEnumerable<SingleOrderResponseModel> Items { get; init; } = Enumerable.Empty<SingleOrderResponseModel>();
}
