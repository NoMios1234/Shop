using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {         

            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if(!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        carName = "Tesla Model S",
                        carShortDesc = "electrocar",
                        carLongtDesc = "Ilon's electrocar",
                        carImg = "/img/tesla_model_x.jpeg",
                        carPrice = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        carName = "Ford Fiesta",
                        carShortDesc = "Тихий и спокойный",
                        carLongtDesc = "Удобный автомобиль для городской жизни",
                        carImg = "/img/ford_fiesta.jpeg",
                        carPrice = 11000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классичиские автомобили"]
                    },
                    new Car
                    {
                        carName = "BMV M3",
                        carShortDesc = "Стильный и быстрый",
                        carLongtDesc = "Удобный автомобиль для городской жизни",
                        carImg = "/img/bmv_m3.jpeg",
                        carPrice = 65000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классичиские автомобили"]
                    }
                );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Электромобили", categoryDesc = "Современный вид транспорта"},
                        new Category {categoryName = "Классичиские автомобили", categoryDesc = "Нестареющая классика"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(var obj in list)
                    {
                        category.Add(obj.categoryName, obj);
                    }
                }
                return category;
            }
        }
    }
}
