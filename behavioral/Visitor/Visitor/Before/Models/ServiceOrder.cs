using Visitor.Before.Models.Orders.Interfaces;

namespace Visitor.Before.Models
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
    }
}
