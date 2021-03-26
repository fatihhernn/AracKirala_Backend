using DataAccess.Abstract;
using Entities;
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
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,Description="BMW",ModelYear=new DateTime(2020,01,01)},
                new Car{Id=2,BrandId=2,ColorId=1,Description="AUDI",ModelYear=new DateTime(2019,02,02)},
                new Car{Id=3,BrandId=3,ColorId=2,Description="SKODA",ModelYear=new DateTime(2018,01,01)},
                new Car{Id=4,BrandId=4,ColorId=2,Description="RENAULT",ModelYear=new DateTime(2020,09,09)},
            };
        }

        public void Add(Car entity)
        {
            _car.Add(entity);

        }

        public void Delete(Car entity)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.Id == entity.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car carToUpdated = _car.SingleOrDefault(p => p.Id == entity.Id);
            carToUpdated.BrandId = entity.BrandId;
            carToUpdated.ColorId = entity.ColorId;
            carToUpdated.Description = entity.Description;
            carToUpdated.ModelYear = entity.ModelYear;
        }
    }
}
