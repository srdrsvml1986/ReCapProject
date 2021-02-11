using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        DataResult<List<Car>> GetAll();
        Result Update(Car entity);
        Result Add(Car entity);
        Result AddRange(List<Car> entities);
        Result Delete(Car entity);
        DataResult<List<CarDetailDto>> GetCarDetails();
    }
}
