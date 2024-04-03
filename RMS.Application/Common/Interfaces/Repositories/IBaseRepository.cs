using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Common.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : EntityBase
    {
    }
}
