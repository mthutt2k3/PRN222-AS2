using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAllOrders() => OrderDAO.GetAllOrders();

        public Order GetOrderById(int id) => OrderDAO.GetOrderById(id);

        public void AddOrder(Order order) => OrderDAO.AddOrder(order);

        public void UpdateOrder(Order order) => OrderDAO.UpdateOrder(order);

        public void DeleteOrder(int id) => OrderDAO.DeleteOrder(id);
    }
}
