#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Old_Glory_Flag.Data;
using Old_Glory_Flag.Models;

namespace Old_Glory_Flag.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly Old_Glory_Flag.Data.Old_Glory_FlagContext _context;

        public IndexModel(Old_Glory_Flag.Data.Old_Glory_FlagContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
