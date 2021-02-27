
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class RentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-JLU6O2DF\SQLEXPRESS2019;Initial Catalog=RentACarDatabase;User ID=sa;Password=1234");
        }

        public DbSet<Car> Cars{ get; set; }
        public DbSet<Color> Colors{ get; set; }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
    }
}
