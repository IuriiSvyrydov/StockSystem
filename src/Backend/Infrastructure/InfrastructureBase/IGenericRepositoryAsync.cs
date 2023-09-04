﻿using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure.InfrastructureBase;

public interface IGenericRepositoryAsync<T> where T : class
{
    Task DeleteRangeAsync(ICollection<T> entity);
    Task<T> GetByIdAsync(T id);
    Task SaveChangesAsync();
    IDbContextTransaction BeginTransaction();
    void Commit();
    void Rollback();
    IQueryable<T> GetTableNoTracking();
    IQueryable<T> GetTableAsAsNoTracking();
    Task<T> AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    Task UpdateAsync(T entity);
    Task UpdateRangeAsync(IEnumerable<T> entities);
    Task DeleteAsync(T entity);
}