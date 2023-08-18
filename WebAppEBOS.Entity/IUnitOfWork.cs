using System.Data;
using WebAppEBOS.Entity.Entites.Interfaces;
using WebAppEBOS.Entity.Repositories.Interfaces;

namespace WebAppEBOS.Entity;

public interface IUnitOfWork 
{
    IRepository<TKey, TEntity> Repository<TKey, TEntity>() 
        where TEntity : class, IEntity<TKey>;
    
    Task<IDbTransaction> BeginTransactionAsync();
    int SaveChanges();
    Task<int> SaveChangesAsync(CancellationToken token = default);
}

