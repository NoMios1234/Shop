using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent dbContent)
        {
            this.appDBContent = dbContent;
        }
        public string shopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

            session.SetString("cartId", shopCartId);
            return new ShopCart(context) { shopCartId = shopCartId };
        }

        public void AddToCart(Car car)
        {
            appDBContent.ShopCarItem.Add(new ShopCartItem
            {
                shopCartId = shopCartId,
                car = car,
                price = car.carPrice
            });

            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return appDBContent.ShopCarItem.Where(c => c.shopCartId == shopCartId).Include(s => s.car).ToList();
        }
    }
}
