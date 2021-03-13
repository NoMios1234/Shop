﻿using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : IGetCars
    {
        private readonly AppDBContent appDBContent;
        public CarRepository(AppDBContent dbContent)
        {
            this.appDBContent = dbContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);
        public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);
        public Car GetObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.carId == carId);

    }
}
