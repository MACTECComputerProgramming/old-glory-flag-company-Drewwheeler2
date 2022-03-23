using System;

namespace OldGloryFlag.Data
{
    public class FlagContext : DbContext
    {
        public FlagContext(DbContextOptions<FlagContext> options) : base(options)
        {
        }

        public DbSet<Customer> { get; set; }
        public DbSet<Order>  { get; set; }
        public DbSet<Products> { get; set; }
    }
}
