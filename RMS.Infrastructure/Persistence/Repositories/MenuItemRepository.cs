using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;
using RMS.Infrastructure.Persistence.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Persistence.Repositories;

public class MenuItemRepository : BaseRepository<MenuItem>, IMenuItemRepository
{
    public MenuItemRepository(EFContext context) : base(context)
    {

    }
}
