using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TimetableMSTeamsIntegration.Common.Domain;

namespace TimetableMSTeamsIntegration.Common.Application
{
    public interface IRepository<TEntity, TKey> where TEntity : IIdentifiable<TKey>
    {
        // CREATE
        Task InsertAsync(TEntity entity);
        Task InsertAsync(IEnumerable<TEntity> entities);

        // READ
        Task<TEntity> GetAsync(TKey id);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter);

        // DELETE
        Task DeleteAsync(TKey id);
        Task DeleteAsync(Expression<Func<TEntity, bool>> filter);

        // UPDATE
        Task UpdateAsync(TEntity entity);
        Task UpdateAsync(IEnumerable<TEntity> entities);
    }
}
