using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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

        public void Update(Color entity)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c => c.Id == entity.Id);
            colorToUpdate.Id = entity.Id;
            colorToUpdate.Name = entity.Name;
        }
    }
}
