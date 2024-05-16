using AutoMapper;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Exceptions;
using RMS.Application.Requests.PaymentRequests;
using RMS.Application.Responses.PaymentResponses;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class PaymentService(IPaymentRepository paymentRepository, IMapper mapper) : IPaymentService
{
    public async Task<PaymentResponse> CreateAsync(CreatePaymentRequestModel request,
        CancellationToken token = default)
    {
        var paymnet = mapper.Map<Payment>(request);
        var response = await paymentRepository.CreateAsync(paymnet, token);
        return mapper.Map<PaymentResponse>(response);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var payment = await paymentRepository.GetAsync(id, token);

        if (payment is null)
        {
            throw new NotFoundException(nameof(payment), id);
        }
        return await paymentRepository.DeleteAsync(payment, token);
    }

    public async Task<List<PaymentResponse>> GetAllAsync(CancellationToken token = default)
    {
        var response = await paymentRepository.GetAllAsync(token);
        return mapper.Map<List<PaymentResponse>>(response);
    }

    public async Task<PaymentResponse?> GetAsync(int id, CancellationToken token = default)
    {
        var response = await paymentRepository.GetAsync(id, token);

        if (response is null)
        {
            throw new NotFoundException(nameof(Payment), id);
        }

        return mapper.Map<PaymentResponse>(response);
    }

    public async Task<bool> UpdateAsync(UpdatePaymentRequestModel request, CancellationToken token = default)
    {
        var payment = await paymentRepository.GetAsync(request.Id, token);

        if (payment is null)
        {
            throw new NotFoundException(nameof(Payment), request.Id);
        }

        payment = mapper.Map<Payment>(request);
        return await paymentRepository.UpdateAsync(payment, token);
    }
}

