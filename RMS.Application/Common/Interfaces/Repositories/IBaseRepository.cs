using RMS.Domain.Abstract;

namespace RMS.Application.Common.Interfaces.Repositories;

public interface IBaseRepository<TEntity> where TEntity : EntityBase
{       
    Task<TEntity> GetAsync(int Id, CancellationToken token = default);
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token = default);
    Task<TEntity> CreateAsync(TEntity entity, CancellationToken token = default);
    Task<bool> UpdateAsync(TEntity entity, CancellationToken token = default);
    Task<bool> DeleteAsync(TEntity entity, CancellationToken token = default);
}
