using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Results.Abstract;
using Core.Results.Concrete;
using Core.Results.Concrete.Data;
using Core.Utilities.Business;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;
        private ICustomerService _customerService;
        private ICarService _carService;

        public RentalManager(IRentalDal rentalDal, ICustomerService customerService,ICarService carService)
        {
            _rentalDal = rentalDal;
            _customerService = customerService;
            _carService = carService;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental entity)
        {
         

            if (_rentalDal.CheckCarStatus(entity.CarId, entity.RentDate, entity.ReturnDate))
            {
                _rentalDal.Add(entity);
                return new SuccessResult("araç başarıyla kiralandı");
            }
            return new ErrorResult("araç kiralanamadı");
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            throw new NotImplementedException();
        }

        public IResult GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            if (_rentalDal.CheckCarStatus(rental.CarId, rental.RentDate, rental.ReturnDate))
            {
                return new ErrorResult("kiralanma tarihleri uygun değildir");
            }
            _rentalDal.Update(rental);
            return new SuccessResult("başarı ile güncellendi");
        }

        public IResult CheckFindexScoreOfCustomer(int customerId, int carId)
        {
            //Araçların kiralanabilmesi için her aracın ayrı ayrı minimum findeks puanı olmalıdır. Bu puanı olmayan müşteriler araç kiralayamaz.

            var result = (_customerService.GetById(customerId).Data.FindexScore >= _carService.GetById(carId).Data.MinFindexScore)&&!string.IsNullOrEmpty(_carService.GetById(carId).Data.MinFindexScore.ToString());


            if (result)
            {
                return new SuccessResult("Findex puanınız yeterli"); 
            }
            return new ErrorResult("Bu aracı kiralamak için yeterli findex puanınız yok");
        }


        public IResult CheckCarStatus(Rental rental)
        {
            if (_rentalDal.CheckCarStatus(rental.CarId, rental.RentDate, rental.ReturnDate))
            {
                return new SuccessResult("kiralanma tarihleri uygundur");
            }
            return new ErrorResult("kiralanma tarihleri uygun değildir");
        }

        public IResult CheckFindexScore(Rental rental)
        {
            var resultOfFindex = BusinessRules.Run(CheckFindexScoreOfCustomer(rental.CustomerId, rental.CarId));
            if (resultOfFindex != null)
            {
                return resultOfFindex;
            }
            return new SuccessResult("Findeks skorunuz uygun");

        }
    }
       
}
