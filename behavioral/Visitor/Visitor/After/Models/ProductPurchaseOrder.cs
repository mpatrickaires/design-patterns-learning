using System.Collections.Immutable;
using Visitor.After.Models.Orders.Interfaces;
using Visitor.After.Services.Interfaces;
using Visitor.Common;

namespace Visitor.After.Models
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

        public T Accept<T>(IOrderVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
