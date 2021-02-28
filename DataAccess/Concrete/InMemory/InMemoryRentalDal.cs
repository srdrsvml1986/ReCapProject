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
    public class InMemoryRentalDal : IRentalDal
    {
        List<Rental> _rental;
        public InMemoryRentalDal()
        {
            _rental = new List<Rental>
            {            
                 new Rental(){CarId=1,CustomerId=1,Date=DateTime.Now.AddDays(-2),ReturnDate=DateTime.Now },
                 new Rental(){CarId=2,CustomerId=1,Date=DateTime.Now },
            };
        }
        public void Add(Rental entity)
        {
            _rental.Add(entity);
        }

        public void Delete(Rental entity)
        {
            Rental colorToDelete = _rental.SingleOrDefault(c => c.Id == entity.Id);
            _rental.Remove(colorToDelete);
        }

        public Task<int> Execute(FormattableString interpolatedQueryString)
        {
            throw new NotImplementedException();
        }

        public Rental Get(int id)
        {
            return _rental.SingleOrDefault(c=> c.Id == id);
        }

        public Rental Get(Expression<Func<Rental, bool>> filter = null)
        {
            throw new NotImplementedException();
        }     

        public List<Rental> GetAll()
        {
            return _rental;
        }

        public List<Rental> GetAll(Expression<Func<Rental, bool>> filter = null)
        {
            return _rental.ToList();
        }

        public Task<IEnumerable<Rental>> GetAllAsync(Expression<Func<Rental, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Rental> GetAsync(Expression<Func<Rental, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<Rental, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public int GetCountAsync(Expression<Func<Rental, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

  

        public Task<IEnumerable<Rental>> GetListAsync(Expression<Func<Rental, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public DbSet<Rental> GetTest()
        {
            throw new NotImplementedException();
        }

        public Rental GetTest(Expression<Func<Rental, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TResult InTransaction<TResult>(Func<TResult> action, Action successAction = null, Action<Exception> exceptionAction = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Rental> Query()
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

        public void Update(Rental entity)
        {
            Rental colorToUpdate = _rental.SingleOrDefault(c => c.Id == entity.Id);
            colorToUpdate.Id = entity.Id;
            colorToUpdate.CarId = entity.CarId;
            colorToUpdate.CustomerId = entity.CustomerId;
            colorToUpdate.Date = entity.Date;
            colorToUpdate.ReturnDate = entity.ReturnDate;
        }

        Rental IEntityRepository<Rental>.Add(Rental entity)
        {
            throw new NotImplementedException();
        }

        Task<int> IEntityRepository<Rental>.GetCountAsync(Expression<Func<Rental, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Rental IEntityRepository<Rental>.Update(Rental entity)
        {
            throw new NotImplementedException();
        }
    }
}
