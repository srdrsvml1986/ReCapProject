using Business.Abstract;
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
        IRentalDal _userDal;

        public RentalManager(IRentalDal colorDal)
        {
            _userDal = colorDal;
        }

        public Result Add(Rental entity)
        {
            _userDal.Add(entity);
            return new SuccessResult();
        }

        public Result AddRange(List<Rental> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
            return new SuccessResult();
        }

        public Result Delete(Rental entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_userDal.GetAll());
        }

        public Result Update(Rental entity)
        {
            _userDal.Update(entity);
            return new SuccessResult();
        }
    }
}
