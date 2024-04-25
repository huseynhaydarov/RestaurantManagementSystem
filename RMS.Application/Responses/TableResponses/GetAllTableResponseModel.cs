using RMS.Application.Responses.ReservationResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Responses.TableResponses;

public record GetAllTableResponseModel
{
    public IEnumerable<SingleTableResponseModel> Items { get; init; } = Enumerable.Empty<SingleTableResponseModel>();
}
