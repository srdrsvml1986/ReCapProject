using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext>, IColorDal
    {
        public List<CarDetailDto> GetCars(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from b in context.Brands
                             join c in context.Cars
                             on b.Id equals c.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             where co.Id == colorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }       
    }
}
