namespace Pronia.Models
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Product> Products { get; set; }
    }
}
