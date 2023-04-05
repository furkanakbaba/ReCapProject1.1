
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //ColorTest();
            //BrandTest();
            //UserTest();
            //RentalTest();
            //CustomerTest();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer1 = new Customer();
            customer1.CompanyName = "%50 indirim";
            customer1.Id = 1;
            customer1.UserId = 1;
            customerManager.Add(customer1);
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental1 = new Rental();
            rental1.CarId = 1;
            rental1.CustomerId = 1;
            rental1.Id = 2;
            rental1.RentDate = (new DateTime(2023, 03, 18));
            rental1.ReturnDate = (new DateTime(2023, 03, 18));
            rentalManager.Add(rental1);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user1 = new User();
            user1.Id = 3;
            user1.FirstName = "Veysel";
            user1.LastName = "Akbaba";
            user1.Password = "123";
            user1.Email = "Deneme@gmail.com";
            userManager.Add(user1);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
        
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
          
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
           
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //AddCarTest(carManager);
            Car car1 = new Car();
            car1.BrandId = 5;
            car1.ColorId = 3;
            car1.DailyPrice = 1555;
            car1.Description = "ikdadas";
            car1.ModelYear = 2008;
            car1.Id = 5;
            //carManager.Add(car1);
            carManager.Delete(car1);
        }

       
        
       


    }
}
