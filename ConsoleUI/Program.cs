using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            DtoSample();
        }

        private static void DtoSample()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4}", item.CarID,
                    item.Description, item.CarBrandName, item.CarColorName,
                    item.DailyPrice, item.ModelYear);
            }
        }

        private static void NewMethod()
        {
            #region GetAll
            BrandManager brandManager2 = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager2.GetAll())
            {
                Console.WriteLine("Brand Name: {0}\nBrand Model: {1}\n", brand.BrandName, brand.BrandModel);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var brand in colorManager.GetAll())
            {
                Console.WriteLine("ColorName: {0}\n", brand.ColorName);

            }

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var brand in carManager.GetAll())
            {
                Console.WriteLine("CarName: {0}\nCar DailyPrice: {1}\n", brand.Description, brand.DailyPrice);
            }

            #endregion

            //#region Add
            //ICarDal carDal = new InMemoryCarDal();
            //carDal.Add(new Car { CarID = 6, CarBrandID = 3, CarColorID = 1, DailyPrice = 185, ModelYear = 2017, Description = "3 Adult, 3 Big Suitcase, Diesel" });

            //foreach (var car in carDal.GetAll())
            //{
            //    Console.WriteLine("Car ID: {0}\nCar ColorID: {1}\nCar DailyPrice: {2},\nDescription: {3}\n", car.CarID, car.CarColorID, car.DailyPrice, car.Description);
            //}
            //#endregion

            //#region Delete
            //IBrandDal brandDal = new InMemoryBrandDal();
            //brandDal.Delete(new Brand { BrandID = 2, BrandName = "Mercedes", BrandModel = "CLA" });
            //foreach (var car in brandDal.GetAll())
            //{
            //    Console.WriteLine("Brand Name: {0}\nBrand Model: {1}\n", car.BrandName, car.BrandModel);
            //}
            //#endregion

            //#region Update
            //IColorDal colorDal = new InMemoryColorDal();
            //colorDal.Update(new Color { ColorID = 2, ColorName = "Green" });
            //foreach (var color in colorDal.GetAll())
            //{
            //    Console.WriteLine("Color ID: {0}\nColor Name: {1}\n", color.ColorID, color.ColorName);
            //}
            //#endregion

            //#region Get
            //Brand brand = brandDal.Get(4);
            //Console.WriteLine("Brand ID: {0}\nBrand Name: {1}\nBrand Model: {2}\n", brand.BrandID, brand.BrandName, brand.BrandModel);
            //#endregion
        }
    }
}
