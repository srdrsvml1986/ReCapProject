using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{Name= "Citroen", Model = "DS7 Crossback"},
                new Brand{Name= "Jeep", Model = "Renegade"},
                new Brand{Name= "Mini Cooper", Model = "Countryman"},
                new Brand{Name= "Audi", Model = "A3"},
                new Brand{Name= "Mercedes", Model = "CLA"}
            };
        }
        public void Add(Brand entity)
        {
            _brands.Add(entity);
        }

        public void Delete(Brand entity)
        {
            Brand colorToDelete = _brands.SingleOrDefault(b => b.Id == entity.Id);
            _brands.Remove(colorToDelete);
        }

        public Task<int> Execute(FormattableString interpolatedQueryString)
        {
            throw new NotImplementedException();
        }

        public Brand Get(int id)
        {
            return _brands.SingleOrDefault(b=> b.Id == id);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null)
        {
            return _brands.FirstOrDefault();
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
                        return _brands;

        }

        public Task<IEnumerable<Brand>> GetAllAsync(Expression<Func<Brand, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Brand> GetAsync(Expression<Func<Brand, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<Brand, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public int GetCountAsync(Expression<Func<Brand, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

   

        public IEnumerable<Brand> GetList(Expression<Func<Brand, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Brand>> GetListAsync(Expression<Func<Brand, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public DbSet<Brand> GetTest()
        {
            throw new NotImplementedException();
        }

        public Brand GetTest(Expression<Func<Brand, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TResult InTransaction<TResult>(Func<TResult> action, Action successAction = null, Action<Exception> exceptionAction = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Brand> Query()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.Id == entity.Id);
            brandToUpdate.Id = entity.Id;
            brandToUpdate.Name = entity.Name;
            brandToUpdate.Model = entity.Model;
        }

        Brand IEntityRepository<Brand>.Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        Task<int> IEntityRepository<Brand>.GetCountAsync(Expression<Func<Brand, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Brand IEntityRepository<Brand>.Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
