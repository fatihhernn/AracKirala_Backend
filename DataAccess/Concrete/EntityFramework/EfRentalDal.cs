using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join cst in context.Customers on r.CustomerId equals cst.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             join u in context.Users on cst.UserId equals u.Id
                             join payment in context.Payments on r.PaymentId equals payment.PaymentId

                             select new RentalDetailDto
                             {
                                 BrandName = b.Description,
                                 RentalId=r.Id,
                                 FullName=u.FirstName+" "+u.LastName,
                                 AmountPaye=payment.AmountPaye,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate                        
                             };

                return result.ToList();
            };
        }
        public bool CheckCarStatus(int carId, DateTime rentDate, DateTime? returnDate)
        {
            using (RentACarContext context = new RentACarContext())
            {
                bool checkReturnDateIsNull = context.Set<Rental>().Any(p => p.CarId == carId && p.ReturnDate == null);
                bool isValidRentDate = context.Set<Rental>()
                    .Any(r => r.CarId == carId && (
                            (rentDate >= r.RentDate && rentDate <= r.ReturnDate) ||
                            (returnDate >= r.RentDate && returnDate <= r.ReturnDate) ||
                            (r.RentDate >= rentDate && r.RentDate <= returnDate)
                            )
                    );

                if ((!checkReturnDateIsNull) && (!isValidRentDate))
                {
                    return true;
                }

                return false;
            }
        }


    }
}
