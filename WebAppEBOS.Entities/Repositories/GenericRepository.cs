using Microsoft.EntityFrameworkCore;
using WebAppEBOS.Entities.EntityModels.Interfaces;
using WebAppEBOS.Entities.Extensions;
using WebAppEBOS.Entities.Repositories.Interfaces;

namespace WebAppEBOS.Entities.Repositories;

public class GenericRepository<TKey, TEntity> :
    GenericReadOnlyRepository<TKey, TEntity>, IRepository<TKey, TEntity>
    where TEntity : class, IEntity<TKey>
{
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(DbContext context) : base(context)
    {
        _dbSet = context.Set<TEntity>();
    }

    #region Add

    public void Add(TEntity item)
    {
        item.ThrowIfNull(nameof(item));
        _dbSet.Add(item);
    }

    public async ValueTask AddAsync(TEntity item, CancellationToken cancellationToken = default)
    {
        item.ThrowIfNull(nameof(item));
        await _dbSet.AddAsync(item, cancellationToken);
    }

    public void AddRange(IEnumerable<TEntity> items)
        => _dbSet.AddRange(items);

    public Task AddRangeAsync(IEnumerable<TEntity> items, CancellationToken cancellationToken = default)
        => _dbSet.AddRangeAsync(items, cancellationToken);

    #endregion

    #region Update&Remove

    public void Update(TEntity item)
    {
        item.ThrowIfNull(nameof(item));
        _dbSet.Update(item);
    }

    public void UpdateRange(IEnumerable<TEntity> items)
        => _dbSet.UpdateRange(items);

    public void Remove(TEntity item)
    {
        item.ThrowIfNull(nameof(item));
        _dbSet.Remove(item);
    }

    public void RemoveRange(IEnumerable<TEntity> items)
        => _dbSet.RemoveRange(items);

    #endregion
}