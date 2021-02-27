using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Results.Abstract;
using Core.Results.Concrete;
using Core.Results.Concrete.Data;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental entity)
        {
       
            foreach (var rentalList in _rentalDal.GetAll())
            {
                //rental listesini dolaş, eğer bu listede kiralayacağımız araba var ve daha araç teslim edilmemiş ise kaydetme
                if (rentalList.CarId == entity.CarId&& entity.RentDate.Date <= rentalList.ReturnDate)
                {
                        return new ErrorResult(Messages.RentalTimeError);                 
                }
            
            }

            _rentalDal.Add(entity);//Kiralanan arabalar içerisinde yoksa kaydet
            return new SuccessResult(Messages.RentedCar);
            
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            throw new NotImplementedException();
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
