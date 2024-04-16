using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Common.Interfaces
{
    public interface IBaseService<TRequest, TResponse>
    {
        Task<TResponse> Create(TRequest request, CancellationToken token = default);
        Task<TResponse> Update(TRequest request, CancellationToken token = default);
        Task Delete(TRequest request, CancellationToken token = default);
        Task<TResponse> GetById(TRequest request, CancellationToken token = default);
    }
}
