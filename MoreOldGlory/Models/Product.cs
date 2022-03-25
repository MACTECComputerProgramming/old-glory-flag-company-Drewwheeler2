namespace MoreOldGlory.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
