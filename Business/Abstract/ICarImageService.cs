using Core.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
      
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int carId);
        IDataResult<CarImage> GetById(int carId);
        IResult Add(IFormFile file, CarImage entity);
        IResult Update(IFormFile file, CarImage entity);
        IResult Delete(IFormFile file, CarImage entity);
    }
}
