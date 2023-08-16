using System.Data;
using WebAppEBOS.Data.Entites.Interfaces;
using WebAppEBOS.Data.Repositories;
using WebAppEBOS.Data.Repositories.Interfaces;

namespace WebAppEBOS.Data;

public interface IUnitOfWork 
{
    IRepository<TKey, TEntity> Repository<TKey, TEntity>() 
        where TEntity : class, IEntity<TKey>;
    
    Task<IDbTransaction> BeginTransactionAsync();
    int SaveChanges();
    Task<int> SaveChangesAsync(CancellationToken token = default);
}

