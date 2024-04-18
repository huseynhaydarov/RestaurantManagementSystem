using RMS.Domain.Abstract;

namespace RMS.Application.Common.Interfaces;

public interface IBaseService<TEntity, BaseRequestEntity, BaseResponseEntity> where TEntity : EntityBase
{
    public void Add(BaseRequestEntity request);

    public TEntity GetById(int id, CancellationToken token = default);

    public IQueryable<TEntity> GetAll(int pageList, int pageNumber, CancellationToken token = default);

    bool Delete(int id);

    BaseRequestEntity Update(int id, BaseRequestEntity requset);
}
