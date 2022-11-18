using Visitor.After.Models.Orders.Interfaces;
using Visitor.After.Services.Interfaces;

namespace Visitor.After.Models
{
    public class ServiceOrder : IOrder
    {
        private decimal _price;
        public string Taker { get; }
        public string Description { get; }
        public decimal Price => _price + Tax;
        public decimal Tax { get; set; }

        public ServiceOrder(string taker, string description, decimal price)
        {
            Taker = taker;
            Description = description;
            _price = price;
        }

        public T Accept<T>(IOrderVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
