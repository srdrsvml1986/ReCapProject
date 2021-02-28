using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ BrandID=1, ColorID=5, ModelYear=2018, DailyPrice= 180, Description="5 Adult / 2 Suitcase / Automatic Shift / Diesel"  },
                new Car{ BrandID=3, ColorID=2, ModelYear=2016, DailyPrice= 220, Description="5 Adult / 3 Suitcase / Manual Shift / Gas"  },
                new Car{ BrandID=4, ColorID=4, ModelYear=2013, DailyPrice= 230, Description="4 Adult / 3 Suitcase / Automatic Shift / Diesel"  },
                new Car{ BrandID=2, ColorID=3, ModelYear=2014, DailyPrice= 210, Description="5 Adult / 2 Suitcase / Manual Shift / Gas"  },
                new Car{ BrandID=5, ColorID=1, ModelYear=2017, DailyPrice= 240, Description="4 Adult / 3 Suitcase / Automatic Shift / Diesel"  }
            };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == entity.Id);
            _cars.Remove(carToDelete);
        }

        public Task<int> Execute(FormattableString interpolatedQueryString)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            return _cars.SingleOrDefault(c=> c.Id == id);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Task<IEnumerable<Car>> GetAllAsync(Expression<Func<Car, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetAsync(Expression<Func<Car, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<Car, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public int GetCountAsync(Expression<Func<Car, bool>> expression = null)
        {
            throw new NotImplementedException();
        }
 

        public Task<IEnumerable<Car>> GetListAsync(Expression<Func<Car, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public DbSet<Car> GetTest()
        {
            throw new NotImplementedException();
        }

        public Car GetTest(Expression<Func<Car, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TResult InTransaction<TResult>(Func<TResult> action, Action successAction = null, Action<Exception> exceptionAction = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Car> Query()
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

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == entity.Id);
            carToUpdate.Id = entity.Id;
            carToUpdate.ColorID = entity.ColorID;
            carToUpdate.BrandID = entity.BrandID;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;
        }

        Car IEntityRepository<Car>.Add(Car entity)
        {
            throw new NotImplementedException();
        }

        Task<int> IEntityRepository<Car>.GetCountAsync(Expression<Func<Car, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Car IEntityRepository<Car>.Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
