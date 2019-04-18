using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RosettiRistorante.Data.Context;
using RosettiRistorante.Data.IRepositories;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DatabaseContext _databaseContext;

        public OrderRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void AddOrder(Order order)
        {
            _databaseContext.Orders.Add(order);
            _databaseContext.SaveChanges();
        }

        public void DeleteOrder(int orderId)
        {
            var order = _databaseContext.Orders.FirstOrDefault(i => i.Id == orderId);
            _databaseContext.Orders.Remove(order ?? throw new InvalidOperationException());
            _databaseContext.SaveChanges();
        }

        public Order GetOrderById(int orderId)
        {
            return _databaseContext.Orders.FirstOrDefault(i => i.Id == orderId);
        }

        public List<Order> GetOrders()
        {
            return _databaseContext.Orders.ToList();
        }

        public void UpdateOrder(Order order)
        {
            var orderUpdated = _databaseContext.Orders.FirstOrDefault(i => i.Id == order.Id);

            if (orderUpdated != null)
            {
                orderUpdated.OrderMeal = order.OrderMeal;
                orderUpdated.Price = order.Price;

                _databaseContext.Orders.Update(orderUpdated);
            }

            _databaseContext.SaveChanges();
        }
    }
}
