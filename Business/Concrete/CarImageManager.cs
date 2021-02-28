using Business.Abstract;
using Business.Contants;
using Business.ValidationRules.FluentValidation;
using Core.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file,CarImage entity)
        {
            var result = BusinessRules.Run(CheckImageLimitExceeded(entity.CarId));
            if (result!=null)
            {
                return result;
            }
            entity.ImagePath = FileHelper.Add(file);
            entity.Date = DateTime.Now;
            _carImageDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }
 
        public IResult Delete(CarImage entity)
        {
            FileHelper.Delete(entity.ImagePath);
            _carImageDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }        
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(x => x.Id == id), Messages.ItemGetted);
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImage entity)
        {
            FileHelper.Update(entity.ImagePath,file);
            _carImageDal.Update(entity);
            return new SuccessResult(Messages.ItemUpdated);
        }
        public IDataResult<List<CarImage>> GetImagesByCarId(int id)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(id));
        }
        private IResult CheckImageLimitExceeded(int carid)
        {
            var carImagecount = _carImageDal.GetAll(p => p.CarId == carid).Count;
            if (carImagecount >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }

            return new SuccessResult();
        }
        private List<CarImage> CheckIfCarImageNull(int id)
        {
            string path = @"\Uploads\Images\logo.jpg";
            var result = _carImageDal.GetAll(c => c.CarId == id).Any();
            if (!result)
            {
                return new List<CarImage> { new CarImage { CarId = id, ImagePath = path, Date = DateTime.Now } };
            }
            return _carImageDal.GetAll(p => p.CarId == id);
        }

        public IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage, bool>> expression = null)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(expression), Messages.ItemsListed);
        }
    }
}
