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
                             join cst in context.Customers on r.Id equals cst.Id
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

      //      select b.Description,u.FirstName+u.LastName from Rentals r inner join Cars c on c.Id=r.CarId 
						                                              //inner join Customers cst on cst.Id=r.CustomerId
						                                              //inner join Brands b on b.Id=c.BrandId
						                                              //inner join Users u on u.Id=cst.UserId

            //public List<CarDetailDto> GetCarDetails()
            //{
            //    using (RentACarContext context = new RentACarContext())
            //    {
            //        var result = from c in context.Cars
            //                     join b in context.Brands on c.BrandId equals b.Id
            //                     join clr in context.Colors on c.ColorId equals clr.Id
            //                     select new CarDetailDto
            //                     {
            //                         BrandName = b.Description,
            //                         CarId = c.Id,
            //                         Description = c.Description,
            //                         DailyPrice = c.DailyPrice,
            //                         ColorName = clr.Description
            //                     };

            //        return result.ToList();
            //    };

            //}


        }
    }
}
