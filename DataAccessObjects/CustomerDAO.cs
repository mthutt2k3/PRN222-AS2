using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO
    {

        public static List<Customer> GetAllCustomers()
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            return _context.Customers.ToList();
        }

        public static Customer GetCustomerById(int id)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            return _context.Customers.Find(id);
        }

        public static void AddCustomer(Customer customer)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public static void UpdateCustomer(Customer customer)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public static void DeleteCustomer(int id)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
