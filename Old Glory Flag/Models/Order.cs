using System;

namespace OldGloryFlag.Model
{
    public class Order
    {
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int CustomerID { get; set; }

        public Order? Orders { get; set; }
    }
}