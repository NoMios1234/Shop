using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetCars _carRep;
        private readonly ShopCart _shopCart;

        public HomeController(IGetCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel {
                favCars = _carRep.GetFavCars
            };
            return View(homeCars);
        }
    }
}
