#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoreOldGlory.Data;
using MoreOldGlory.Models;

namespace MoreOldGlory.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly MoreOldGlory.Data.MoreOldGloryContext _context;

        public DetailsModel(MoreOldGlory.Data.MoreOldGloryContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order.FirstOrDefaultAsync(m => m.ID == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
