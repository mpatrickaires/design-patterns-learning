using System.Collections.Immutable;
using Visitor.Before.Models.Orders.Interfaces;
using Visitor.Common;

namespace Visitor.Before.Models
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
    }
}
