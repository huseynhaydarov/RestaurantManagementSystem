using Microsoft.EntityFrameworkCore;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Abstract;
using RMS.Infrastructure.Persistence.DataBases;
using System.Collections.Generic;

namespace RMS.Infrastructure.Persistence.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase
{
   
    private readonly EFContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public BaseRepository(EFContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public void Create(TEntity entity, CancellationToken token = default)
    {
       _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(TEntity entity, CancellationToken token = default)
    {
        _dbSet.Remove(entity);
    }

    public IQueryable<TEntity> GetAll(int pageList, int pageNumber, CancellationToken token = default)
    {
        return _dbSet.Skip<TEntity>(pageList * pageNumber).Take<TEntity>(pageList);
    }

    public TEntity GetById(int id, CancellationToken token = default)
    {
        TEntity? foundEntity = _dbSet.Find(id);
        if (foundEntity == null) throw new ArgumentNullException(nameof(foundEntity));
        return foundEntity;
    }

    public void Update(TEntity entity, CancellationToken token = default)
    {
        _dbSet.Update(entity);
    }
}


