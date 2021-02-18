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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal colorDal)
        {
            _rentalDal = colorDal;
        }

        public Result Add(Rental entity)
        {
            _rentalDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public Result AddRange(List<Rental> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult(Messages.Added);
        }

        public Result Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public DataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.ItemsListed);
        }
        public DataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(x => x.Id == id), Messages.ItemGetted);
        }
        public Result Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}
