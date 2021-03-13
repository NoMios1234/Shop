using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int carId { get; set; }
        public string carName { get; set; }
        public string carShortDesc { get; set; }
        public string carLongtDesc { get; set; }
        public string carImg { get; set; }
        public ushort carPrice { get; set; }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
