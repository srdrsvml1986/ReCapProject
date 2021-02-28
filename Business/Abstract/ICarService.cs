using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> expression = null);
        IDataResult<Car> GetById(int id);
        IResult Update(Car entity);
        IResult Add(Car entity);
        IResult AddRange(List<Car> entities);
        IResult Delete(Car entity);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
