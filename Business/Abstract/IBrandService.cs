using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> expression = null);
        IDataResult<Brand> GetById(int id);
        IResult Update(Brand brand);
        IResult Add(Brand brand);
        IResult AddRange(List<Brand> entities);
        IResult Delete(Brand brand);
        IDataResult<List<CarDetailDto>> GetCars(int id);
    }
}
