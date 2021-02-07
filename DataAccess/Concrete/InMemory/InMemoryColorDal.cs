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
                new Color{ ColorName = "White"},
                new Color{ ColorName = "Black"},
                new Color{ ColorName= "Grey"},
                new Color{ ColorName= "Blue" },
                new Color{ ColorName= "Red" }
            };
        }
        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(Color entity)
        {
            Color colorToDelete = _colors.SingleOrDefault(c => c.ColorID == entity.ColorID);
            _colors.Remove(colorToDelete);
        }

        public Color Get(int id)
        {
            return _colors.SingleOrDefault(c=> c.ColorID == id);
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
            Color colorToUpdate = _colors.SingleOrDefault(c => c.ColorID == entity.ColorID);
            colorToUpdate.ColorID = entity.ColorID;
            colorToUpdate.ColorName = entity.ColorName;
        }
    }
}
