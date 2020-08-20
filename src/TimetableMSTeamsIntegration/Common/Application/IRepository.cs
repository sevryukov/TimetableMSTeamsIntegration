using System;
using System.Collections.Generic;

namespace TimetableMSTeamsIntegration.Common.Application
{
    public interface IRepository<T> where T: IIdentifible
    {
        //Create
        Task InsertAsync(T entity);
        Task InsertAsync(IEnumerable<T> entities);

        //Read
        Task<T> GetAsync(Guid id);
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter);

        //Delete
        Task DeleteAsync(Guid id);
        Task DeleteAsync(Expression<Func<T, bool>> filter);
    }
}