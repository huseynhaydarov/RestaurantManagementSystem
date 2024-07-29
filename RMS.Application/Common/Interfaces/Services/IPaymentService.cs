using RMS.Application.Requests.OrderRequests;
using RMS.Application.Requests.PaymentRequests;
using RMS.Application.Responses.OrderResponses;
using RMS.Application.Responses.PaymentResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Common.Interfaces.Services
{
    public interface IPaymentService
    {
        Task<PaymentResponse?> GetAsync(int id, CancellationToken token = default);

        Task<List<PaymentResponse>> GetAllAsync(CancellationToken token = default);

        Task<PaymentResponse> CreateAsync(CreatePaymentRequestModel request, CancellationToken token = default);

        Task<bool> UpdateAsync(UpdatePaymentRequestModel request, CancellationToken token = default);

        Task<bool> DeleteAsync(int id, CancellationToken token = default);
    }
}
