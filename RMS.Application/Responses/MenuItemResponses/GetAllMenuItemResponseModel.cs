using RMS.Application.Responses.CustomerResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Responses.MenuItemResponses
{
    public record GetAllMenuItemResponseModel
    {
        public IEnumerable<SingleMenuItemResponseModel> Items { get; init; } = Enumerable.Empty<SingleMenuItemResponseModel>();
    }

}
