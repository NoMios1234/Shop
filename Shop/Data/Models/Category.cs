using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string categoryDesc { get; set; }
        public List<Car> cars { get; set; }
    }
}
