#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Old_Glory_Flag.Models;

namespace Old_Glory_Flag.Data
{
    public class Old_Glory_FlagContext : DbContext
    {
        public Old_Glory_FlagContext (DbContextOptions<Old_Glory_FlagContext> options)
            : base(options)
        {
        }

        public DbSet<Old_Glory_Flag.Models.Customer> Customer { get; set; }

        public DbSet<Old_Glory_Flag.Models.Product> Product { get; set; }
    }
}
