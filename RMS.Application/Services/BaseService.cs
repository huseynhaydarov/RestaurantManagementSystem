using AutoMapper;
using RMS.Application.Common.Interfaces;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services
{
    public abstract class BaseService<TEntity, TBaseRequestEntity, TBaseResponseEntity> : IBaseService<TEntity, TBaseRequestEntity, TBaseResponseEntity> 
        where TEntity : EntityBase
        where TBaseRequestEntity : class
        where TBaseResponseEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public BaseService(IMapper mapper, IBaseRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public void Add(TBaseRequestEntity request)
        {
            var mappedEntity = _mapper.Map<TBaseRequestEntity, TEntity>(request);
            _repository.Add(mappedEntity);
        }
 

        public bool Delete(int id)
        {
            _repository.FindById(id);
            return false;

        }

        public IQueryable<TEntity> GetAll(int pageList, int pageNumber, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public TBaseResponseEntity Get(int id, CancellationToken token = default)
        {
            var response = _repository.FindById(id, token);
            var test = _mapper.Map<TBaseResponseEntity>(response);
            return test;
        }

        public TBaseRequestEntity Update(int id, TBaseRequestEntity requset)
        {
            throw new NotImplementedException();
        }

        TEntity IBaseService<TEntity, TBaseRequestEntity, TBaseResponseEntity>.GetById(int id, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
