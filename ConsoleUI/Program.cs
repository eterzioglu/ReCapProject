using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }

            carManager.Add(new Car()
            {
                Id = 5,
                BrandId = 3,
                ColorId = 2,
                ModelYear = "2010",
                DailyPrice = 1500,
                Description = "Güzel araba"
            }) ;
        }
    }
}
