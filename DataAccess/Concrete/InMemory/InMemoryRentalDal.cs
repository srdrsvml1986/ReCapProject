using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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

        public void Update(Rental entity)
        {
            Rental colorToUpdate = _rental.SingleOrDefault(c => c.Id == entity.Id);
            colorToUpdate.Id = entity.Id;
            colorToUpdate.CarId = entity.CarId;
            colorToUpdate.CustomerId = entity.CustomerId;
            colorToUpdate.Date = entity.Date;
            colorToUpdate.ReturnDate = entity.ReturnDate;
        }
    }
}
