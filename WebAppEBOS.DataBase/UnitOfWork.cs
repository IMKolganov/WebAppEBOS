using System.Collections.Concurrent;
using System.Data;
using Microsoft.EntityFrameworkCore;
using WebAppEBOS.Entities.EntityModels.Interfaces;
using WebAppEBOS.Entities.Extensions;
using WebAppEBOS.Entities.Repositories;
using WebAppEBOS.Entities.Repositories.Interfaces;

namespace WebAppEBOS.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    private readonly ConcurrentDictionary<Type, object> _repositories =  new();

    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _context = dbContext.ThrowIfNull(nameof(dbContext));
        
        _context.ChangeTracker.AutoDetectChangesEnabled = false;
        _context.ChangeTracker.LazyLoadingEnabled = false;
        _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
    }

    public object getDbContext() { return _context; }
    public IRepository<TKey, TEntity> Repository<TKey, TEntity>() 
        where TEntity : class, IEntity<TKey>
    {
        var repositoryKey = typeof(TEntity);

        if(_repositories.TryGetValue(repositoryKey, out var repository)) 
        {
            return (IRepository<TKey, TEntity>) repository;
        }

        var instance = new GenericRepository<TKey, TEntity>(_context);
        _repositories.TryAdd(repositoryKey, instance);

        return instance;
    }


    public Task<IDbTransaction> BeginTransactionAsync()
    {
        throw new NotImplementedException();
    }

    public int SaveChanges() => _context.SaveChanges();

    public Task<int> SaveChangesAsync(CancellationToken token = default) 
        => _context.SaveChangesAsync(token);

    public void Dispose()
    {
       // Ignored
    }
}