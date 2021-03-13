using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDBContent appDB, ShopCart cart)
        {
            this.appDBContent = appDB;
            this.shopCart = cart;
        }
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(new Order 
            { 
                orderName = order.orderName,
                orderAddress = order.orderAddress,
                orderPhone = order.orderPhone,
                email = order.email,
                orderTime = order.orderTime
            });
            appDBContent.SaveChanges();

            var items = shopCart.listShopItems;
            List<Order> currOrder = appDBContent.Order.Where(t => t.orderTime == order.orderTime).OrderBy(t => t.orderId).ToList();

            foreach (var el in items)
            {
                appDBContent.OrderDetail.Add(new OrderDetail 
                {
                    orderId = currOrder[0].orderId,
                    carId = el.car.carId,
                    price = el.car.carPrice
                });
            }
            appDBContent.SaveChanges();
        }
    }
}
