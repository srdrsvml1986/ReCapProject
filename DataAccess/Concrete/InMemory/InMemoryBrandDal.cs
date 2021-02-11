using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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

        public void Update(Brand entity)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.Id == entity.Id);
            brandToUpdate.Id = entity.Id;
            brandToUpdate.Name = entity.Name;
            brandToUpdate.Model = entity.Model;
        }
    }
}
