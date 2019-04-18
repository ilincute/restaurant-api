using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.IRepositories
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetOrderById(int orderId);
        void AddOrder(Order order);
        void DeleteOrder(int orderId);
        void UpdateOrder(Order order);
    }
}
