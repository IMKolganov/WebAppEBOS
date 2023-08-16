using Microsoft.EntityFrameworkCore;
using WebAppEBOS.Data.Entites.Interfaces;
using WebAppEBOS.Data.Extensions;
using WebAppEBOS.Data.PageData;
using WebAppEBOS.Data.Repositories.Interfaces;
using WebAppEBOS.Data.Specifications;
using WebAppEBOS.Data.Specifications.Interfaces;

namespace WebAppEBOS.Data.Repositories;

public class GenericReadOnlyRepository<TKey, TEntity> :
    IReadOnlyRepository<TKey, TEntity>
    where TEntity : class, IEntity<TKey>
{
    private readonly DbSet<TEntity> _dbSet;

    // ReSharper disable once MemberCanBeProtected.Global
    public GenericReadOnlyRepository(DbContext context)
    {
        _dbSet = context.Set<TEntity>();
    }

    public async Task<TEntity> GetAsync(TKey id, CancellationToken token = default)
    {
        var result = await _dbSet.FindAsync(new object?[] { id }, cancellationToken: token);

        return result ?? throw new Exception($"{typeof(TEntity)} {id}");
    }

    public async Task<TEntity?> FindAsync(TKey id, CancellationToken token = default)
        => await _dbSet.FindAsync(new object?[] { id }, cancellationToken: token);

    public async Task<TEntity?> FindAsync(IExpressionSpecification<TEntity> specification,
        CancellationToken token = default)
    {
        specification.ThrowIfNull(nameof(specification));

        var item = await _dbSet
            .FirstOrDefaultAsync(specification.Expression, cancellationToken: token);

        return item;
    }

    public Task<bool> AnyAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default)
    {
        specification.ThrowIfNull(nameof(specification));
        return _dbSet.AnyAsync(specification.Expression, cancellationToken: token);
    }

    public Task<bool> ExistAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default)
        => AnyAsync(specification, token);

    public Task<TEntity> SingleAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default)
    {
        specification.ThrowIfNull(nameof(specification));
        return _dbSet.SingleAsync(specification.Expression, cancellationToken: token);
    }

    public Task<TEntity?> SingleOrDefaultAsync(IExpressionSpecification<TEntity> specification,
        CancellationToken token = default)
    {
        specification.ThrowIfNull(nameof(specification));
        return _dbSet.SingleOrDefaultAsync(specification.Expression, cancellationToken: token);
    }

    public Task<TEntity> FirstAsync(IExpressionSpecification<TEntity> specification, CancellationToken token = default)
    {
        specification.ThrowIfNull(nameof(specification));
        return _dbSet.FirstAsync(specification.Expression, cancellationToken: token);
    }

    public Task<TEntity?> FirstOrDefaultAsync(IExpressionSpecification<TEntity> specification,
        CancellationToken token = default)
    {
        specification.ThrowIfNull(nameof(specification));
        return _dbSet.FirstOrDefaultAsync(specification.Expression, cancellationToken: token);
    }

    public async Task<IReadOnlyCollection<TEntity>> FetchAsync(IQuerySpecification<TEntity> specification,
        CancellationToken token = default)
    {
        specification.ThrowIfNull(nameof(specification));

        var items = await _dbSet
            .BuildQuery(specification)
            .ToArrayAsync(cancellationToken: token);

        return items;
    }

    public async Task<PageResult<TEntity>> FetchAsync(IPageSpecification<TEntity> specification,
        CancellationToken token = default)
    {
        specification.ThrowIfNull(nameof(specification));
        
        var skipCount = specification.Index * specification.Size;
        var items = await _dbSet
            .BuildQuery(specification)
            .ToArrayAsync(cancellationToken: token);
        
        var total = await _dbSet.CountAsync(specification.Expression, cancellationToken: token);

        var result = new PageResult<TEntity>
        {
            Total = total,
            Items = items
        };

        return result;
    }
}