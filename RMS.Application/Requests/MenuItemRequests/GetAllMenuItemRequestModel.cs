using RMS.Domain.Entities;
using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Requests.MenuItemRequestModel;

public record GetAllMenuItemRequestModel
{
    public IEnumerable<MenuItem> Items { get; init; } = Enumerable.Empty<MenuItem>();
}
