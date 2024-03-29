﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             join b in context.Brands
                             on ca.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 CarId = ca.Id,
                                 BrandId = ca.BrandId,
                                 ColorId = ca.ColorId,
                                 CarName = ca.Description,
                                 ColorName = co.Name,
                                 BrandName = b.Name,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,
                                 DailyPrice = ca.DailyPrice,
                                 CarImage = (from i in context.CarImages where (i.CarId == ca.Id) 
                                             select new CarImage { Id = i.Id,CarId = ca.Id,Date = i.Date,ImagePath = i.ImagePath}).ToList().Count == 0
                                                    ? new List<CarImage> { new CarImage { Id = -1, CarId = ca.Id, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" } }
                                                    : (from i in context.CarImages
                                                       where (ca.Id == i.CarId)
                                                       select new CarImage
                                                       {
                                                           Id = i.Id,
                                                           CarId = i.CarId,
                                                           Date = i.Date,
                                                           ImagePath = i.ImagePath
                                                       }).ToList()
                             };
                //return result.ToList();
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
