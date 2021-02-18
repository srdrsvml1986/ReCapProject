using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public DataResult<List<Brand>> GetAll()
        {
           return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.ItemsListed);
        }
   
        public Result Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.ItemUpdated);
        }

        public Result Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }

        public Result Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.Deleted);
        }
        public DataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.Id == id),Messages.ItemGetted);
        }
        public Result AddRange(List<Brand> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult(Messages.Added);
        }
    }
}
