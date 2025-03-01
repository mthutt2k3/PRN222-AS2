using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObjects;

namespace TranThiMinhThuRazorPages.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly BusinessObjects.Ass2SignalRRazorPagesContext _context;

        public CreateModel(BusinessObjects.Ass2SignalRRazorPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EmployeeDetail EmployeeDetail { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EmployeeDetails.Add(EmployeeDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
