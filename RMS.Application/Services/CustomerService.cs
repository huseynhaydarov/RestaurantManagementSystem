using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces;
using AutoMapper;
using RMS.Domain.Entities;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Responses.CustomerResponses;

namespace RMS.Application.Services;

    public class CustomerService : BaseService<Customer, CustomerRequestModel, CustomerResponseModel>, ICustomerService
    {
        public CustomerService(IMapper mapper, IBaseRepository<Customer> repository) : base(mapper, repository)
        {
        }

}

