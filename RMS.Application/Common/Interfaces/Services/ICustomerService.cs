using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Responses.CustomerResponses;

namespace RMS.Application.Common.Interfaces.Services;

public interface ICustomerService
{
    Task<CustomerResponse?> GetAsync(int id, CancellationToken token = default);

    Task<List<CustomerResponse>> GetAllAsync(CancellationToken token = default);

    Task<CustomerResponse> CreateAsync(CreateCustomerRequestModel request, CancellationToken token = default);

    Task<bool> UpdateAsync(UpdateCustomerRequestModel request, CancellationToken token = default);

    Task<bool> DeleteAsync(int id, CancellationToken token = default);
}