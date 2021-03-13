using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IGetCars _getCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IGetCars iGetCars, ICarsCategory iCarsCategory)
        {
            _getCars = iGetCars;
            _carsCategory = iCarsCategory;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(_category))
            {
                cars = _getCars.Cars.OrderBy(i => i.carId);
            }
            else
            {
                if(string.Equals("electro", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _getCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i => i.carId);
                    currCategory = cars.First().Category.categoryName;
                }
                else if(string.Equals("fuel", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _getCars.Cars.Where(i => i.Category.categoryName.Equals("Классичиские автомобили")).OrderBy(i => i.carId);
                    currCategory = cars.First().Category.categoryName;
                }         
            }
            var carObj = new CarsListViewModel
            {
                Cars = cars,
                CurrCategory = currCategory
            };

            ViewBag.Title = "Cars";

            return View(carObj);
        }
    }
}
