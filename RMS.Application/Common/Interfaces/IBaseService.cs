using RMS.Application.Requests;
using RMS.Application.Responses;
using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Common.Interfaces
{
    public interface IBaseService<TEntity, TResponseModel, TRequestModel> 
        where TEntity : EntityBase
        where TRequestModel : BaseRequest
        where TResponseModel : BaseResponse
    {
        IEnumerable<TResponseModel> GetAll();

        TResponseModel Get(int id);
        void Add(TRequestModel request);
        TRequestModel Update(int id, TRequestModel request);
        bool Delete(int id);

    }
}
