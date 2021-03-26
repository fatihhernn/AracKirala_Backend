using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
 

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in filter==null? context.Cars:context.Cars.Where(filter)
                             join b in context.Brands on c.BrandId equals b.Id
                             join clr in context.Colors on c.ColorId equals clr.Id
                          
                             select new CarDetailDto
                             {
                                 BrandName = b.Description,
                                 CarId = c.Id,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = clr.Description,
                                 BrandId=b.Id,
                                 ColorId=clr.Id
                                
                             };

                return result.ToList();
            };

        }
    }
}
