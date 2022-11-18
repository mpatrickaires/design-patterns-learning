namespace Visitor.Common
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; } // Weight in grams
        public ProductCategory Category { get; set; }
        public Product(string name, decimal price, decimal weight, ProductCategory category)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Category = category;
        }
    }
}
