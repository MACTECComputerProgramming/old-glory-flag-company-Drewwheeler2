using System;
using System.Collections.Generic;

namespace Old_Glory_Flag.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }

        public ICollection<Customer>? Customers { get; set; }
    }
}
