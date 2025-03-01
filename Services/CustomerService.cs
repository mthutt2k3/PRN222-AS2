using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetAllCustomers() => _customerRepository.GetAllCustomers();

        public Customer GetCustomerById(int id) => _customerRepository.GetCustomerById(id);

        public void AddCustomer(Customer customer) => _customerRepository.AddCustomer(customer);

        public void UpdateCustomer(Customer customer) => _customerRepository.UpdateCustomer(customer);

        public void DeleteCustomer(int id) => _customerRepository.DeleteCustomer(id);
    }
}
