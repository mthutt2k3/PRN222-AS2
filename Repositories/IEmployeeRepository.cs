using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IEmployeeRepository
    {
        List<EmployeeDetail> GetAllEmployees();
        EmployeeDetail GetEmployeeById(int id);
        void AddEmployee(EmployeeDetail employee);
        void UpdateEmployee(EmployeeDetail employee);
        void DeleteEmployee(int id);
    }
}
