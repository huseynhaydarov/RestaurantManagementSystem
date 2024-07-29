using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;
using RMS.Infrastructure.Persistence.DataBases;

namespace RMS.Infrastructure.Persistence.Repositories;
public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
{
    public PaymentRepository(EFContext context) : base(context)
    {
    }
}