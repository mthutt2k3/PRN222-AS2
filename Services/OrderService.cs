using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAllOrders() => _orderRepository.GetAllOrders();

        public Order GetOrderById(int id) => _orderRepository.GetOrderById(id);

        public void AddOrder(Order order) => _orderRepository.AddOrder(order);

        public void UpdateOrder(Order order) => _orderRepository.UpdateOrder(order);

        public void DeleteOrder(int id) => _orderRepository.DeleteOrder(id);
    }
}
