using Business.Abstract;
using Business.Contants;
using Business.ValidationRules.FluentValidation;
using Core.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
 
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.ItemUpdated);
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.Deleted);
        }
        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.Id == id), Messages.ItemGetted);
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult AddRange(List<Brand> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> expression = null)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(expression), Messages.ItemsListed);
        }
    }
}
