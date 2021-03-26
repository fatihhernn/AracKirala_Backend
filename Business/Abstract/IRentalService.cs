using Core.Results.Abstract;
using Core.Results.Concrete.Data;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {

        IResult Add(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int rentalId);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IResult GetRentalDetails();

    }
}
