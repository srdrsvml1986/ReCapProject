using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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

        public void Update(Customer entity)
        {
            Customer colorToUpdate = _customer.SingleOrDefault(c => c.Id == entity.Id);
            colorToUpdate.Id = entity.Id;
            colorToUpdate.UserId = entity.UserId;
            colorToUpdate.CompanyName = entity.CompanyName;
        }
    }
}
