namespace NexusProduct_Service_API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
