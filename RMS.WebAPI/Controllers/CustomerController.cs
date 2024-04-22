﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Common.Interfaces;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Responses.CustomerResponses;

namespace RMS.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

    [HttpPost]
    public void Add(CreateCustomerRequestModel customer)
    {
        _customerService.Add(customer);
    }

    [HttpGet("id")]
 

    [HttpPut("id")]
    public void Update(int id, CreateCustomerRequestModel customer) 
    {
        _customerService.Update(id, customer);
    }


    [HttpDelete("id")]

    public void Delete(int id)
    {
       _customerService.Delete(id);
    }
}


