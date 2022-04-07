#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FlagGlory.Data;
using MoreOldGlory.Models;

namespace FlagGlory.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly FlagGlory.Data.FlagGloryContext _context;

        public IndexModel(FlagGlory.Data.FlagGloryContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
