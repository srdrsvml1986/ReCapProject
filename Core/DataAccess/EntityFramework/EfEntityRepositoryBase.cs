using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
            return entity;
        }
        public TEntity Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
            return entity;
        }
        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            using (TContext context = new TContext())
            {
                return expression == null ? await context.Set<TEntity>().ToListAsync() :await context.Set<TEntity>().Where(expression).ToListAsync();
            }
        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            using (TContext context = new TContext())
            {
                return await context.Set<TEntity>().SingleOrDefaultAsync(expression);
            }
        }    

        public IQueryable<TEntity> Query()
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>();
            }
        }

        public async Task<int> GetCountAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return await Query().CountAsync();
        }

        public int GetCount(Expression<Func<TEntity, bool>> expression = null)
        {
              return Query().Count();
        }
    }
}
