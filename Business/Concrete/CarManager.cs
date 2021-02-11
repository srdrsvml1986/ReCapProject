using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Result Add(Car entity)
        {
          _carDal.Add(entity);
            return new SuccessResult();
        }

        public Result AddRange(List<Car> entity)
        {
            foreach (var item in entity)
            {
                Add(item);
            }
            return new SuccessResult();
        }

        public Result Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public DataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public Result Update(Car entity)
        {
            _carDal.Update(entity);
            return new SuccessResult();
        }
    }
}
