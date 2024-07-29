using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;
using RMS.Infrastructure.Persistence.DataBases;

namespace RMS.Infrastructure.Persistence.Repositories;

public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(EFContext context) : base(context)
    {
    }
}
