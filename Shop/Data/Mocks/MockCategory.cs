using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> GetCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", categoryDesc = "Современный вид транспорта"},
                    new Category {categoryName = "Классичиские автомобили", categoryDesc = "Нестареющая классика"} 
                };
            }
        }
    }
}
