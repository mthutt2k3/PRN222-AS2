using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        public List<Customer> GetAllCustomers() => CustomerDAO.GetAllCustomers();

        public Customer GetCustomerById(int id) => CustomerDAO.GetCustomerById(id);

        public void AddCustomer(Customer customer) => CustomerDAO.AddCustomer(customer);

        public void UpdateCustomer(Customer customer) => CustomerDAO.UpdateCustomer(customer);

        public void DeleteCustomer(int id) => CustomerDAO.DeleteCustomer(id);
    }
}
