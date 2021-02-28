using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> expression = null);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null);
        T Get(Expression<Func<T, bool>> expression);       
        Task<T> GetAsync(Expression<Func<T, bool>> expression);       
        IQueryable<T> Query();
        Task<int> GetCountAsync(Expression<Func<T, bool>> expression = null);
        int GetCount(Expression<Func<T, bool>> expression = null);

    }
}
