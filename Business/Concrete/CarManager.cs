using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        
        public void Add(Car car)
        {
            using(CarDatabaseContext context = new CarDatabaseContext())
            {
                if(car.DailyPrice > 0 && context.Brands.SingleOrDefault(b=>b.BrandId == car.BrandId).BrandName.Length > 2)
                {
                    _carDal.Add(car);
                    Console.WriteLine("Car added database succesfully");
                }
                else
                {
                    Console.WriteLine("System error. Car couldn£t added the database");
                }
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
           return _carDal.GetCarDetails();
        }
    }
}
