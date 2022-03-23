using System;
namespace OldFloryFlag.Pages.Model
{
    public class Customer
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
