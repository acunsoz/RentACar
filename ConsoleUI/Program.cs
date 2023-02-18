using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();

            //ColorManagerTest();

            //BrandManagerTest();

            //UserTest();

            //CustomerTest();


            RentalManager rentalmanager = new RentalManager(new EfRentalDal());

            Console.WriteLine(rentalmanager.GetAll().Data);

            //foreach (var rental in rentalmanager.GetAll())
            //{
            //    Console.WriteLine(rental.CarId + rental.RentDate);
            //}

        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            foreach (var customer in customerManager.GetCustomerDetails().Data)
            {
                Console.WriteLine(customer.FirstName +customer.LastName+customer.CompanyName  + customer.Email);
            }
            

            //customerManager.Add(new Customer { UserId = 1, CompanyName = "Budget kiralama" });

            //customerManager.Add(new Customer { UserId = 2, CompanyName = "Avis kiralama" });

            //customerManager.Add(new Customer { UserId = 3, CompanyName = "Paşa oto kiralama" });
        }
        /*
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            User user1 = new User { FirstName = "Alihan", LastName = "Acunsoz", Email = "alihan@gmail.com", Password = "12345" };
            userManager.Add(user1);

            userManager.Add(new User { FirstName = "Tunahan", LastName = "Acunsoz", Email = "tunahan@gmail.com", Password = "12345" });

            userManager.Add(new User { FirstName = "Emre", LastName = "Cetinkaya", Email = "emre@gmail.com", Password = "12345" });
        }*/

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine(brandManager.GetBrandId(2));

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine(colorManager.GetColorId(2));

            foreach (var colorId in colorManager.GetAll().Data)
            {
                Console.WriteLine(colorId.Name);
            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success ==true)
            {
                foreach(var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "/" + car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
