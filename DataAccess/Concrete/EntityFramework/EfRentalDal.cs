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

                             select new RentalDetailDto
                             {
                                 BrandName = b.Description,
                                 RentalId=r.Id,
                                 FullName=u.FirstName+" "+u.LastName
                             };

                return result.ToList();
            };
        }

       
    }
}
