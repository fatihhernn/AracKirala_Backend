using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Results.Abstract;
using Core.Results.Concrete;
using Core.Results.Concrete.Data;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
       
        ICarImageDal _carImageDal;
        ICarService _carService;
        public CarImageManager(ICarImageDal carImageDal, ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
        }

        //[ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage entity)
        {
            var result = BusinessRules.Run(CheckNumOfCarImages(entity.CarId));

            if (result != null)
            {
                return result;
            }

            entity.ImagePath = FileHelper.AddAsync(file);
            entity.ImageDate = DateTime.Now;
            _carImageDal.Add(entity);

            return new SuccessResult("Resim eklendi");
        }
        public IResult Delete(IFormFile file, CarImage entity)
        {
            _carImageDal.Delete(entity);
            return new SuccessResult("Resim silindi");
        }

        public IDataResult<List<CarImage>> GetAll()
        {

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), "Resimler Listelendi");
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(carId), Messages.CarListedByCarId);
        }

        public IDataResult<CarImage> GetById(int carId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarId == carId));
        }

        public IResult Update(IFormFile file, CarImage entity)
        {
            _carImageDal.Add(entity);
            return new SuccessResult("Resim Güncellendi");
        }
        private IResult CheckNumOfCarImages(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult("Arabaya eklenebilecek resim sayısı aşıldı");
            }
            return new SuccessResult();

        }
        private List<CarImage> CheckIfCarImageNull(int carId)
        {
            //default bir path oluştur
            string path = @"\Images\carLogo.jpg";

            //Car tablosundan Id'ye göre obje çek. (_carImage =>Ctor'da CarService injection ile sağlanır.)
            Car carData = _carService.GetById(carId).Data;

            //çekilen datayı, CarImage tablosunda dön
            var result = _carImageDal.GetAll(c => c.CarId == carData.Id).Any();

            //eğer carImage tablosunda verilen Id'de Car yok ise default verilen ImagePath'i göster. 
            if (!result)
            {
                return new List<CarImage> { new CarImage { CarId = carId, ImagePath = path, ImageDate = DateTime.Now } };
            }
            return _carImageDal.GetAll(p => p.CarId == carId);
        }



    }
}
