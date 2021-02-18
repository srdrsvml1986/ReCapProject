using Business.Concrete;
using ConsoleTables;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //DtoSample();

            InsertSampleDataOnDatabase();



        }

        private static void InsertSampleDataOnDatabase()
        {

            UserManager userManagerEf = new UserManager(new EfUserDal());
            if (userManagerEf.GetAll().Data.Count == 0)
            {
                UserManager userManagerMemory = new UserManager(new InMemoryUserDal());


                userManagerEf.AddRange(userManagerMemory.GetAll().Data);

                CustomerManager customerManagerMemory = new CustomerManager(new InMemoryCustomerDal());
                CustomerManager customerManagerEf = new CustomerManager(new EfCustomerDal());

                customerManagerEf.AddRange(customerManagerMemory.GetAll().Data);

                ColorManager colorManagerMemory = new ColorManager(new InMemoryColorDal());
                ColorManager colorManagerEf = new ColorManager(new EfColorDal());

                colorManagerEf.AddRange(colorManagerMemory.GetAll().Data);

                BrandManager brandManagerMemory = new BrandManager(new InMemoryBrandDal());
                BrandManager brandManagerEf = new BrandManager(new EfBrandDal());

                brandManagerEf.AddRange(brandManagerMemory.GetAll().Data);

                CarManager carManagerMemory = new CarManager(new InMemoryCarDal());
                CarManager carManagerEf = new CarManager(new EfCarDal());

                carManagerEf.AddRange(carManagerMemory.GetAll().Data);

                RentalManager rentalManagerMemory = new RentalManager(new InMemoryRentalDal());
                RentalManager rentalManagerEf = new RentalManager(new EfRentalDal());

                rentalManagerEf.AddRange(rentalManagerMemory.GetAll().Data);

                Console.WriteLine("Örnek veriler yüklendi.");
            }

        }

        private static void DtoSample()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ConsoleTable.From(carManager.GetCarDetails().Data).Write();
        }

        private static void NewMethod()
        {
            #region GetAll
            BrandManager brandManager2 = new BrandManager(new EfBrandDal());

            ConsoleTable.From(brandManager2.GetAll().Data).Write();

            ColorManager colorManager = new ColorManager(new EfColorDal());

            ConsoleTable.From(colorManager.GetAll().Data).Write();

            CarManager carManager = new CarManager(new EfCarDal());

            ConsoleTable.From(carManager.GetAll().Data).Write();

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
