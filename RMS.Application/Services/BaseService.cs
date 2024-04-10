using RMS.Application.Common.Interfaces;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Requests;
using RMS.Application.Responses;
using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services
{
    public abstract class BaseService<TEntity, TResponseModel, TRequestModel> : IBaseService<TEntity, TResponseModel, TRequestModel>
        where TEntity : EntityBase
        where TResponseModel : BaseResponse
        where TRequestModel : BaseRequest
    {
        private readonly IBaseRepository<TEntity>? _repository;

        public void Add(TRequestModel request)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TResponseModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResponseModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public TRequestModel Update(int id, TRequestModel request)
        {
            throw new NotImplementedException();
        }
    }
}
