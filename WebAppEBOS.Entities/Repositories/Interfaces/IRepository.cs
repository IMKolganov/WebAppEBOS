using WebAppEBOS.Entities.EntityModels.Interfaces;

namespace WebAppEBOS.Entities.Repositories.Interfaces;

public interface IRepository<in TKey, TEntity> : IReadOnlyRepository<TKey, TEntity>
    where TEntity: IEntity<TKey>
{
    void Add(TEntity item);
    ValueTask AddAsync(TEntity item, CancellationToken cancellationToken = default);
    void AddRange(IEnumerable<TEntity> items);
    Task AddRangeAsync(IEnumerable<TEntity> items, CancellationToken cancellationToken = default);
    void Update(TEntity item);
    void UpdateRange(IEnumerable<TEntity> items);
    void Remove(TEntity item);
    void RemoveRange(IEnumerable<TEntity> items);
}


