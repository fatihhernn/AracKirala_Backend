using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager cars = new CarManager(new InMemoryCarDal());

            //CARTOTEST();


            //cardetails();

            CustomerManager customers = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customers.Add(new Entities.Concrete.Customer { UserId = 1, CompanyName = "Kalem Yazılım" }).Message);
            
        }

        private static void cardetails()
        {
            CarManager cars = new CarManager(new EfCarDal());

            Console.WriteLine(cars.GetCarDetails().Message); 
        }

        private static void CARTOTEST()
        {
            CarManager cars = new CarManager(new EfCarDal());

            foreach (var car in cars.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
