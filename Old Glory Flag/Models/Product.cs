namespace Old_Glory_Flag.Models


{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
    


