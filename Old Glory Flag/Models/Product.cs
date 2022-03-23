using System;

namespace OldGloryFlag.Model
{


    public class Products
    {
        public int OrderID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public ICollections<Order> Orders { get; set; }
    }
}
