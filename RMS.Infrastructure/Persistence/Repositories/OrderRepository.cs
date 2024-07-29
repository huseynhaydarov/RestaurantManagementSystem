using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;
using RMS.Infrastructure.Persistence.DataBases;

namespace RMS.Infrastructure.Persistence.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(EFContext context) : base(context)
        {
        }
    }
}

