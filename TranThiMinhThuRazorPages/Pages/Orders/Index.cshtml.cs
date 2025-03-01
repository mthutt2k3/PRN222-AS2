using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;

namespace TranThiMinhThuRazorPages.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObjects.Ass2SignalRRazorPagesContext _context;

        public IndexModel(BusinessObjects.Ass2SignalRRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.ToListAsync();
        }
    }
}
