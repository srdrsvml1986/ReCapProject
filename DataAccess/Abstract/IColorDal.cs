using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
        List<CarDetailDto> GetCars(int colorId);
    }
}
