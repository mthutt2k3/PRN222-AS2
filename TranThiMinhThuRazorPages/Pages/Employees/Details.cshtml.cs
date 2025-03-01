using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;

namespace TranThiMinhThuRazorPages.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly BusinessObjects.Ass2SignalRRazorPagesContext _context;

        public DetailsModel(BusinessObjects.Ass2SignalRRazorPagesContext context)
        {
            _context = context;
        }

        public EmployeeDetail EmployeeDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeedetail = await _context.EmployeeDetails.FirstOrDefaultAsync(m => m.Id == id);
            if (employeedetail == null)
            {
                return NotFound();
            }
            else
            {
                EmployeeDetail = employeedetail;
            }
            return Page();
        }
    }
}
