using RMS.Domain.Abstract;

namespace RMS.Application.Common.Interfaces.Repositories;

public interface IBaseRepository<TEntity> where TEntity : EntityBase
{       
    public void Create(TEntity entity, CancellationToken token = default);

    public TEntity GetById(int id, CancellationToken token = default);

    public IQueryable<TEntity> GetAll(int pageList, int pageNumber, CancellationToken token = default);

    public void Delete(TEntity entity, CancellationToken token = default);

    public void Update(TEntity entity, CancellationToken token = default);

}
