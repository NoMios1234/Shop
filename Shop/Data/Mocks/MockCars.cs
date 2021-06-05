using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IGetCars
    {
        public readonly ICarsCategory _categoryCars = new MockCategory();
        
        public IEnumerable<Car> Cars 
        { 
            get => new List<Car> { 
                new Car {
                    carName = "Tesla Model S", 
                    carShortDesc = "electrocar", 
                    carLongtDesc = "Ilon's electrocar", 
                    carImg = "/img/tesla_model_x.jpeg", 
                    carPrice = 45000, 
                    isFavourite = true, 
                    available = true, 
                    Category = _categoryCars.GetCategories.First()
                },
                new Car {
                    carName = "Ford Fiesta", 
                    carShortDesc = "Тихий и спокойный", 
                    carLongtDesc = "Удобный автомобиль для городской жизни", 
                    carImg = "/img/ford_fiesta.jpeg", 
                    carPrice = 11000, 
                    isFavourite = false, 
                    available = true,
                    Category = _categoryCars.GetCategories.Last()
                },
                new Car {
                    carName = "BMV M3",
                    carShortDesc = "Стильный и быстрый",
                    carLongtDesc = "Удобный автомобиль для городской жизни",
                    carImg = "/img/bmv_m3.jpeg",
                    carPrice = 65000,
                    isFavourite = true,
                    available = true,
                    Category = _categoryCars.GetCategories.Last()
                }
            }; 
            set => throw new NotImplementedException(); }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
