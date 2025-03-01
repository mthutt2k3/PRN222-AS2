using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;
using Services;

namespace TranThiMinhThuRazorPages.Pages.Customers
{
    public class EditModel : PageModel
    {
        private readonly ICustomerService _customerService;

        public EditModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [BindProperty]
        public Customer Customer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerService.GetCustomerById(int.Parse(id));
            if (customer == null)
            {
                return NotFound();
            }

            Customer = customer;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _customerService.UpdateCustomer(Customer);
            }
            catch (Exception)
            {
                //if (!_customerService.CustomerExists(Customer.CustomerId))
                //{
                //    return NotFound();
                //}
                //else
                //{
                    throw;
                //}
            }

            return RedirectToPage("./Index");
        }
    }
}
