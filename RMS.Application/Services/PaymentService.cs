using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class PaymentService(IBaseRepository<Payment> paymentRepository)
{
    private readonly IBaseRepository<Payment> _paymentRepository = paymentRepository;
    public async Task<Payment> CreateAsync(Payment payment, CancellationToken token = default)
    {
        return await _paymentRepository.CreateAsync(payment, token);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var payment = await _paymentRepository.GetAsync(id);
        if (payment == null)
        {
            return false;
        }
        return await _paymentRepository.DeleteAsync(payment, token);
    }

    public async Task<IEnumerable<Payment>> GetAllAsync(CancellationToken token = default)
    {
        return await _paymentRepository.GetAllAsync(token);
    }

    public  async Task<Payment> GetAsync(int id, CancellationToken token = default)
    {
        return await _paymentRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Payment payment, CancellationToken token = default)
    {
        var isPaymentExist = await _paymentRepository.GetAsync(payment.Id, token);

        if (isPaymentExist == null)
        {
            return false;
        }
        return await _paymentRepository.UpdateAsync(payment, token);
    }
}


