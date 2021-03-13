using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent dbContent)
        {
            this.appDBContent = dbContent;
        }
        public IEnumerable<Category> GetCategories => appDBContent.Category;
    }
}
