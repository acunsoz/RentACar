﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1,ColorId = 1,ModelYear="2015",DailyPrice = 200,Description = "BMW İ3" },
                new Car{Id = 2, BrandId = 1,ColorId = 2,ModelYear="2020",DailyPrice = 250,Description = "Yeni BMW İX" },
                new Car{Id = 3, BrandId = 2,ColorId = 4,ModelYear="2016",DailyPrice = 150,Description = "Volkswagen Polo" },
                new Car{Id = 4, BrandId = 2,ColorId = 1,ModelYear="2019",DailyPrice = 250,Description = "Volkswagen T-Roc" },
                new Car{Id = 5, BrandId = 3,ColorId = 3,ModelYear="2018",DailyPrice = 500,Description = "Chevrolet Camaro" },
                new Car{Id = 6, BrandId = 4,ColorId = 3,ModelYear="2000",DailyPrice = 100,Description = "Renault Symbol" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;    
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;  

        }
    }
}
