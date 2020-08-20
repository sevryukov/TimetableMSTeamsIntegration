using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TimetableMSTeamsIntegration.Common.Application;
using TimetableMSTeamsIntegration.Common.Domain;

namespace TimetableMSTeamsIntegration.Common.Infrastructure.Repository
{
    public abstract class MSSQLRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class, IIdentifiable<TKey>
    {
        private readonly DbContext _database;
        private readonly DbSet<TEntity> _set;
        public MSSQLRepository(DbContext database)
        {
            _database = database;
            _set = _database.Set<TEntity>();
        }
        public virtual async Task DeleteAsync(TKey id)
        {
            var entity = await _set.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (entity != null)
            {
                _set.Remove(entity);

                await _database.SaveChangesAsync();
            }
        }
        public virtual async Task DeleteAsync(Expression<Func<TEntity, bool>> filter)
        {
            var entities = await _set.Where(filter).ToListAsync();

            if (entities != null && entities.Count > 0)
            {
                _set.RemoveRange(entities);

                await _database.SaveChangesAsync();
            }
        }
        public virtual async Task<TEntity> GetAsync(TKey id)
        {
            return await _set.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        public virtual async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _set.Where(filter).ToListAsync();
        }
        public virtual async Task InsertAsync(TEntity entity)
        {
            await _set.AddAsync(entity);
            await _database.SaveChangesAsync();
        }
        public virtual async Task InsertAsync(IEnumerable<TEntity> entities)
        {
            await _set.AddRangeAsync(entities);
            await _database.SaveChangesAsync();
        }
        public virtual async Task UpdateAsync(TEntity entity)
        {
            _set.Update(entity);
            await _database.SaveChangesAsync();
        }
        public virtual async Task UpdateAsync(IEnumerable<TEntity> entities)
        {
            _set.UpdateRange(entities);
            await _database.SaveChangesAsync();
        }
    }
}