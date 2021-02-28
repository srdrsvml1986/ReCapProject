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
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color{ Name = "White"},
                new Color{ Name = "Black"},
                new Color{ Name= "Grey"},
                new Color{ Name= "Blue" },
                new Color{ Name= "Red" }
            };
        }
        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(Color entity)
        {
            Color colorToDelete = _colors.SingleOrDefault(c => c.Id == entity.Id);
            _colors.Remove(colorToDelete);
        }

        public Task<int> Execute(FormattableString interpolatedQueryString)
        {
            throw new NotImplementedException();
        }

        public Color Get(int id)
        {
            return _colors.SingleOrDefault(c=> c.Id == id);
        }

        public Color Get(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }     

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _colors.ToList();
        }

        public Task<IEnumerable<Color>> GetAllAsync(Expression<Func<Color, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Color> GetAsync(Expression<Func<Color, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<Color, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public int GetCountAsync(Expression<Func<Color, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

   

        public Task<IEnumerable<Color>> GetListAsync(Expression<Func<Color, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public DbSet<Color> GetTest()
        {
            throw new NotImplementedException();
        }

        public Color GetTest(Expression<Func<Color, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TResult InTransaction<TResult>(Func<TResult> action, Action successAction = null, Action<Exception> exceptionAction = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Color> Query()
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

        public void Update(Color entity)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c => c.Id == entity.Id);
            colorToUpdate.Id = entity.Id;
            colorToUpdate.Name = entity.Name;
        }

        Color IEntityRepository<Color>.Add(Color entity)
        {
            throw new NotImplementedException();
        }

        Task<int> IEntityRepository<Color>.GetCountAsync(Expression<Func<Color, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Color IEntityRepository<Color>.Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
