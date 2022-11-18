using System.Collections.Immutable;
using Visitor.Before.Models.Orders.Interfaces;
using Visitor.Common;

namespace Visitor.Before.Models
{
    public class ProductPurchaseOrder : IOrder
    {
        private readonly string _taker;
        private readonly IEnumerable<Product> _products;

        public string Taker => _taker;
        public decimal Price => _products.Sum(p => p.Price) + Tax;
        public decimal Tax { get; set; }
        public IEnumerable<Product> Products => _products.ToImmutableList();

        public ProductPurchaseOrder(string taker, IEnumerable<Product> products)
        {
            _taker = taker;
            _products = products;
        }
    }
}
