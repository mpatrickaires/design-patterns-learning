namespace Visitor.Common.Data
{
    public static class ProductsFactory
    {
        public static IEnumerable<Product> GenerateProductsCollection() => new List<Product>
        {
            new Product("T-Shirt", 20m, 300m, ProductCategory.Clothing),
            new Product("Television", 500m, 5000m, ProductCategory.Electronics),
            new Product("Band-Aid Pack", 8m, 20m, ProductCategory.Medicine),
        };
    }
}
