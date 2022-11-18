using System.Collections.Immutable;
using Visitor.After.Models.Orders.Interfaces;
using Visitor.After.Services.Interfaces;
using Visitor.Common;

namespace Visitor.After.Models
{
    public class ShippingOrder : IOrder
    {
        private readonly decimal _price;
        private readonly IEnumerable<Product> _products;

        public string Taker { get; }
        public decimal Price => _price + Tax;
        public decimal Tax { get; set; }
        public ShippingType ShippingType { get; }
        public decimal Weight => _products.Sum(p => p.Weight);
        public IEnumerable<Product> Products => _products.ToImmutableList();

        public ShippingOrder(string taker, decimal price, ShippingType shippingType, IEnumerable<Product> products)
        {
            Taker = taker;
            _price = price;
            ShippingType = shippingType;
            _products = products;
        }

        public T Accept<T>(IOrderVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
