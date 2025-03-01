using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<EmployeeDetail> GetAllEmployees() => _employeeRepository.GetAllEmployees();

        public EmployeeDetail GetEmployeeById(int id) => _employeeRepository.GetEmployeeById(id);

        public void AddEmployee(EmployeeDetail employee) => _employeeRepository.AddEmployee(employee);

        public void UpdateEmployee(EmployeeDetail employee) => _employeeRepository.UpdateEmployee(employee);

        public void DeleteEmployee(int id) => _employeeRepository.DeleteEmployee(id);
    }
}
