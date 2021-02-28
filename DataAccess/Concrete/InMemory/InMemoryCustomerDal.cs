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
    public class InMemoryCustomerDal : ICustomerDal
    {
        List<Customer> _customer;
        public InMemoryCustomerDal()
        {
            _customer = new List<Customer>
            {
                new Customer{UserId=1,CompanyName="X firması"}
            };
        }
        public void Add(Customer entity)
        {
            _customer.Add(entity);
        }

        public void Delete(Customer entity)
        {
            Customer colorToDelete = _customer.SingleOrDefault(c => c.Id == entity.Id);
            _customer.Remove(colorToDelete);
        }

        public Task<int> Execute(FormattableString interpolatedQueryString)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            return _customer.SingleOrDefault(c=> c.Id == id);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }     

        public List<Customer> GetAll()
        {
            return _customer;
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return _customer.ToList();
        }

        public Task<IEnumerable<Customer>> GetAllAsync(Expression<Func<Customer, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetAsync(Expression<Func<Customer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<Customer, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public int GetCountAsync(Expression<Func<Customer, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

    

        public Task<IEnumerable<Customer>> GetListAsync(Expression<Func<Customer, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public DbSet<Customer> GetTest()
        {
            throw new NotImplementedException();
        }

        public Customer GetTest(Expression<Func<Customer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TResult InTransaction<TResult>(Func<TResult> action, Action successAction = null, Action<Exception> exceptionAction = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> Query()
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

        public void Update(Customer entity)
        {
            Customer colorToUpdate = _customer.SingleOrDefault(c => c.Id == entity.Id);
            colorToUpdate.Id = entity.Id;
            colorToUpdate.UserId = entity.UserId;
            colorToUpdate.CompanyName = entity.CompanyName;
        }

        Customer IEntityRepository<Customer>.Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        Task<int> IEntityRepository<Customer>.GetCountAsync(Expression<Func<Customer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Customer IEntityRepository<Customer>.Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
