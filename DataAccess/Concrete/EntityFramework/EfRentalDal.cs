using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from re in context.Rentals
                             join c in context.Cars 
                             on re.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cus in context.Customers
                             on re.CustomerId equals cus.Id
                             join u in context.Users
                             on cus.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CarName = b.Name,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate
                             };
                return result.ToList();

            }
        }
    }
}
