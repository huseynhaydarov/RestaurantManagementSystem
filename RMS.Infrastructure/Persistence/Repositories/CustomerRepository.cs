using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<Customer> Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task IBaseRepository<Customer>.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

