﻿using System.Data;
using WebAppEBOS.Entities.EntityModels.Interfaces;
using WebAppEBOS.Entities.Repositories.Interfaces;

namespace WebAppEBOS.Data;

public interface IUnitOfWork 
{
    IRepository<TKey, TEntity> Repository<TKey, TEntity>() 
        where TEntity : class, IEntity<TKey>;
    
    Task<IDbTransaction> BeginTransactionAsync();
    int SaveChanges();
    Task<int> SaveChangesAsync(CancellationToken token = default);
}
