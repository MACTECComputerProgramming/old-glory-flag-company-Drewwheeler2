#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoreOldGlory.Models;

namespace FlagGlory.Data
{
    public class FlagGloryContext : DbContext
    {
        public FlagGloryContext (DbContextOptions<FlagGloryContext> options)
            : base(options)
        {
        }

        public DbSet<MoreOldGlory.Models.Customer> Customer { get; set; }

        public DbSet<MoreOldGlory.Models.Order> Order { get; set; }

        public DbSet<MoreOldGlory.Models.Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Product>().ToTable("Producst");
            modelBuilder.Entity<Order>().ToTable("Order");
        }




    }
}
