using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Responses.CustomerResponses;

public record GetAllCustomerResponseModel
{
    public IEnumerable<SingleCustomerResponseModel> Items { get; init; } = Enumerable.Empty<SingleCustomerResponseModel>();
}
