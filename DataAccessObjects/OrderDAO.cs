using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDAO
    {

        // Lấy danh sách tất cả đơn hàng
        public static List<Order> GetAllOrders()
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            return _context.Orders.ToList();
        }

        // Lấy thông tin đơn hàng theo ID
        public static Order GetOrderById(int id)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            return _context.Orders.Find(id);
        }

        // Thêm đơn hàng mới
        public static void AddOrder(Order order)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        // Cập nhật thông tin đơn hàng
        public static void UpdateOrder(Order order)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        // Xóa đơn hàng theo ID
        public static void DeleteOrder(int id)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
