﻿#nullable disable
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
    public class IndexModel : PageModel
    {
        private readonly MoreOldGlory.Data.MoreOldGloryContext _context;

        public IndexModel(MoreOldGlory.Data.MoreOldGloryContext context)
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
