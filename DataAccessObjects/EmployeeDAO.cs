using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class EmployeeDAO
    {

        // Lấy danh sách tất cả nhân viên
        public static List<EmployeeDetail> GetAllEmployees()
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();

            return _context.EmployeeDetails.ToList();
        }

        // Lấy thông tin nhân viên theo ID
        public static EmployeeDetail GetEmployeeById(int id)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();
            return _context.EmployeeDetails.Find(id);
        }

        // Thêm nhân viên mới
        public static void AddEmployee(EmployeeDetail employee)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();
            _context.EmployeeDetails.Add(employee);
            _context.SaveChanges();
        }

        // Cập nhật thông tin nhân viên
        public static void UpdateEmployee(EmployeeDetail employee)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();
            _context.EmployeeDetails.Update(employee);
            _context.SaveChanges();
        }

        // Xóa nhân viên theo ID
        public static void DeleteEmployee(int id)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();
            var employee = _context.EmployeeDetails.Find(id);
            if (employee != null)
            {
                _context.EmployeeDetails.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
