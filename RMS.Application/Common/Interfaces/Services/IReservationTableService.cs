using RMS.Application.Requests.ReservationRequests;
using RMS.Application.Requests.TableRequests;
using RMS.Application.Responses.ReservationResponses;
using RMS.Application.Responses.TableResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Common.Interfaces.Services
{
    public interface IReservationTableService
    {
        Task<ReservationTableResponse?> GetAsync(int id, CancellationToken token = default);

        Task<List<ReservationTableResponse>> GetAllAsync(CancellationToken token = default);

        Task<ReservationTableResponse> CreateAsync(CreateTableRequestModel request, CancellationToken token = default);

        Task<bool> UpdateAsync(UpdateTableRequestModel request, CancellationToken token = default);

        Task<bool> DeleteAsync(int id, CancellationToken token = default);
    }
}
