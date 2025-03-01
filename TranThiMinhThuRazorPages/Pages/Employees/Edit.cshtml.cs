using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;

namespace TranThiMinhThuRazorPages.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly BusinessObjects.Ass2SignalRRazorPagesContext _context;

        public EditModel(BusinessObjects.Ass2SignalRRazorPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EmployeeDetail EmployeeDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeedetail =  await _context.EmployeeDetails.FirstOrDefaultAsync(m => m.Id == id);
            if (employeedetail == null)
            {
                return NotFound();
            }
            EmployeeDetail = employeedetail;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EmployeeDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeDetailExists(EmployeeDetail.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployeeDetailExists(string id)
        {
            return _context.EmployeeDetails.Any(e => e.Id == id);
        }
    }
}
