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
    public class IndexModel : PageModel
    {
        private readonly BusinessObjects.Ass2SignalRRazorPagesContext _context;

        public IndexModel(BusinessObjects.Ass2SignalRRazorPagesContext context)
        {
            _context = context;
        }

        public IList<EmployeeDetail> EmployeeDetail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            EmployeeDetail = await _context.EmployeeDetails.ToListAsync();
        }
    }
}
