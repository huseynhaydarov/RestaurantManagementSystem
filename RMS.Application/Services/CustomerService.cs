﻿using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces;
using AutoMapper;
using RMS.Application.Exceptions;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class CustomerService(ICustomerRepository customerRepository, IMapper mapper) : ICustomerService
{
    public async Task<CustomerResponse> CreateAsync(CreateCustomerRequestModel request,
        CancellationToken token = default)
    {
        var customer = mapper.Map<Customer>(request);
        var response = await customerRepository.CreateAsync(customer, token);
        return mapper.Map<CustomerResponse>(response);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var customer = await customerRepository.GetAsync(id, token);
        if (customer is null)
        {
            throw new NotFoundException(nameof(Customer), id);
        }

        return await customerRepository.DeleteAsync(customer, token);
    }

    public async Task<List<CustomerResponse>> GetAllAsync(CancellationToken token = default)
    {
        
        var response = await customerRepository.GetAllAsync(token);
        return mapper.Map<List<CustomerResponse>>(response);
    }

    public async Task<CustomerResponse?> GetAsync(int id, CancellationToken token = default)
    {
        var response = await customerRepository.GetAsync(id, token);

        if (response is null)
        {
            throw new NotFoundException(nameof(Customer), id);
        }

        return mapper.Map<CustomerResponse>(response);
    }

    public async Task<bool> UpdateAsync(UpdateCustomerRequestModel request, CancellationToken token = default)
    {
        var customer = await customerRepository.GetAsync(request.Id, token);

        if (customer is null)
        {
            throw new NotFoundException(nameof(Customer), request.Id);
        }

        customer = mapper.Map<Customer>(request);
        return await customerRepository.UpdateAsync(customer, token);
    }
}