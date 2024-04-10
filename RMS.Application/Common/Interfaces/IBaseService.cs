using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Common.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : EntityBase
    {

    }
}
