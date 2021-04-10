using Core.DataAccess;
using Core.Results.Abstract;
using Core.Results.Concrete.Data;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetails();
        bool CheckCarStatus(int carId, DateTime rentDate, DateTime? returnDate);
        
    }
}
