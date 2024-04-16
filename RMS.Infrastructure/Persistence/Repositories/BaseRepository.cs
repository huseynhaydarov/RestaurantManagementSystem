using Microsoft.EntityFrameworkCore;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Abstract;
using RMS.Infrastructure.Persistence.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Persistence.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase
{
    private readonly DbSet<TEntity> _set;
    private readonly EFContext _context;

    public BaseRepository(EFContext context)
    {
        _context = context;
        _set = context.Set<TEntity>();
    }

    public async Task<TEntity> CreateAsync(TEntity entity, CancellationToken token = default)
    {
        var result = await _set.AddAsync(entity);
        await _context.SaveChangesAsync(token);
        return result.Entity;
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(TEntity entity, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetAsync(int Id, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(TEntity entity, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}


