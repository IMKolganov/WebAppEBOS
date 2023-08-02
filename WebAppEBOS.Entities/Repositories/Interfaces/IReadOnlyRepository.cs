using WebAppEBOS.Entities.EntityModels.Interfaces;
using WebAppEBOS.Entities.PageData;
using WebAppEBOS.Entities.Specifications.Interfaces;

namespace WebAppEBOS.Entities.Repositories.Interfaces;

public interface IReadOnlyRepository<in TKey, TEntity> 
where TEntity : IEntity<TKey>
{
    Task<TEntity> GetAsync(TKey id, CancellationToken token = default);
    Task<TEntity?> FindAsync(TKey id, CancellationToken token = default);
    Task<TEntity?> FindAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default);
    Task<bool> AnyAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default);
    Task<bool> ExistAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default);
    Task<TEntity> SingleAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default);
    Task<TEntity?> SingleOrDefaultAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default);
    Task<TEntity> FirstAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default);
    Task<TEntity?> FirstOrDefaultAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default);
    Task<IReadOnlyCollection<TEntity>> FetchAsync(IQuerySpecification<TEntity> specification, CancellationToken token = default);
    Task<PageResult<TEntity>> FetchAsync(IPageSpecification<TEntity> specification, CancellationToken token = default);
}