using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<EmployeeDetail> GetAllEmployees() => EmployeeDAO.GetAllEmployees();

        public EmployeeDetail GetEmployeeById(int id) => EmployeeDAO.GetEmployeeById(id);

        public void AddEmployee(EmployeeDetail employee) => EmployeeDAO.AddEmployee(employee);

        public void UpdateEmployee(EmployeeDetail employee) => EmployeeDAO.UpdateEmployee(employee);

        public void DeleteEmployee(int id) => EmployeeDAO.DeleteEmployee(id);
    }
}
