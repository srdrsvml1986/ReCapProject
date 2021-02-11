using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context=new RentACarContext())
            {
                var result = from ca in context.Cars
                             join renk in context.Colors
                             on ca.ColorID equals renk.Id
                             join b in context.Brands on ca.BrandID equals b.Id
                             select new CarDetailDto { 
                             CarID=ca.ID,
                             CarBrandName=b.Name,
                             CarColorName=renk.Name,
                             DailyPrice=ca.DailyPrice,
                             ModelYear=ca.ModelYear,
                             Description=ca.Description
                             };

                return result.ToList();
            }
        }
    }
}
