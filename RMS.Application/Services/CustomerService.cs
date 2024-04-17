using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RMS.Application.Responses.CustomerResponses;
using RMS.Application.Requests.CustomerRequests;
using RMS.Domain.Entities;

namespace RMS.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerResponseModel> Create(CustomerRequestModel request, CancellationToken token = default)
        {
            var customer = _mapper.Map<Customer>(request);
            customer = await _customerRepository.CreateAsync(customer);
            return _mapper.Map<CustomerResponseModel>(customer);
        }

        public Task Delete(CustomerRequestModel request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerResponseModel> GetById(CustomerRequestModel request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerResponseModel> Update(CustomerRequestModel request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

       
    }
}
