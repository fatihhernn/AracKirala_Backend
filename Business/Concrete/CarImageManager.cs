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
        //ICarImageDal _carImageDAL;
        //ICarService _carService;

        //public CarImageManager(ICarImageDal carImageDAL ,ICarService carService)
        //{
        //    _carImageDAL = carImageDAL;
        //    _carService = carService;
        //}
        //[ValidationAspect(typeof(CarImageValidator))]
        //public IResult Add(CarImage carImage,IFormFile file)
        //{
        //    IResult result = BusinessRules.Run(

        //           CheckImageLimitExceeded(carImage.CarId)

        //           );

        //    if (result != null)
        //    {
        //        return result;
        //    }
        //    if (file!=null)
        //    {
        //        carImage.ImagePath = FileHelper.Add(file);
        //    }

        //    carImage.Date = DateTime.Now;
        //    _carImageDAL.Add(carImage);
        //    return new SuccessResult(Messages.CarImagesAdded);
        //}



        //public IResult Delete(CarImage carImage)
        //{
        //    IResult result = BusinessRules.Run(

        //        CarImageDelete(carImage)

        //        );

        //    if (result != null)
        //    {
        //        return result;
        //    }

        //    _carImageDAL.Delete(carImage);
        //    return new SuccessResult(Messages.CarImageDeleted);
        //}

        //public IDataResult<CarImage> Get(int id)
        //{
        //    return new SuccessDataResult<CarImage>(_carImageDAL.Get(p => p.Id == id),Messages.CarImageListedById);
        //}

        //public IDataResult<List<CarImage>> GetAll()
        //{
        //    return new SuccessDataResult<List<CarImage>>(_carImageDAL.GetAll(),Messages.AllCarImagesListed);
        //}

        //public IDataResult<List<CarImage>> GetImagesByCarId(int id)
        //{
        //    return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(id),Messages.CarListedByCarId);
        //}

        //public IResult Update(CarImage carImage, IFormFile file)
        //{
        //    carImage.ImagePath = FileHelper.Update(_carImageDAL.Get(p => p.Id == carImage.Id).ImagePath, file);
        //    carImage.Date = DateTime.Now;
        //    _carImageDAL.Update(carImage);
        //    return new SuccessResult();
        //}







        ////business rules
        //private IResult CheckImageLimitExceeded(int carid)
        //{
        //    var carImagecount = _carImageDAL.GetAll(p => p.CarId == carid).Count;
        //    if (carImagecount >= 5)
        //    {
        //        return new ErrorResult(Messages.CarImageLimitExceeded);
        //    }

        //    return new SuccessResult();
        //}

        //private List<CarImage> CheckIfCarImageNull(int carId)
        //{
        //    //default bir path oluştur
        //    string path = Directory.GetCurrentDirectory()+ @"\Images\carLogo.jpg";        

        //    //Car tablosundan Id'ye göre obje çek. (_carImage =>Ctor'da CarService injection ile sağlanır.)
        //    Car carData= _carService.GetById(carId).Data;

        //    //çekilen datayı, CarImage tablosunda dön
        //    var result = _carImageDAL.GetAll(c => c.CarId == carData.Id).Any();

        //    //eğer carImage tablosunda verilen Id'de Car yok ise default verilen ImagePath'i göster. 
        //    if (!result)
        //    {
        //        return new List<CarImage> { new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now } };
        //    }
        //    return _carImageDAL.GetAll(p => p.CarId == carId);
        //}

        //private IResult CarImageDelete(CarImage carImage)
        //{
        //    try
        //    {
        //        File.Delete(carImage.ImagePath);
        //    }
        //    catch (Exception exception)
        //    {
        //        return new ErrorResult(exception.Message);
        //    }

        //    return new SuccessResult();
        //}
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
