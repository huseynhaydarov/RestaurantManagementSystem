using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Responses.CustomerResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Common.Interfaces
{
    public interface ICustomerService : IBaseService<CustomerRequestModel, CustomerResponseModel>
    {

    }
}
