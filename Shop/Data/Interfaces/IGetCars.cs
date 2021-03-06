using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IGetCars
    {
        public IEnumerable<Car> Cars { get; }
        public IEnumerable<Car> GetFavCars { get; }
        public Car GetObjectCar(int carId);
    }
}
