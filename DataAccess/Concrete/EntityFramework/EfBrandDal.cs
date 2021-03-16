using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
        public List<CarDetailDto> GetCars(int brandId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from b in context.Brands
                             join c in context.Cars
                             on b.Id equals c.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             where b.Id==brandId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName=b.Name,
                                 ColorName=co.Name,
                                 DailyPrice=c.DailyPrice,
                                 ModelYear=c.ModelYear,                                
                                 Description=c.Description
                             };
                return result.ToList();
            }
        }
    }
}
