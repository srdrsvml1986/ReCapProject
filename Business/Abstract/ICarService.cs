using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Update(Car entity);
        void Add(Car entity);
        void Delete(Car entity);
        List<CarDetailDto> GetCarDetails();
    }
}
