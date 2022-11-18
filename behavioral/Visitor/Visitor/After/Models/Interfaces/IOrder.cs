using Visitor.After.Services.Interfaces;

namespace Visitor.After.Models.Orders.Interfaces
{
    public interface IOrder
    {
        string Taker { get; }
        decimal Price { get; }
        decimal Tax { get; set; }

        TReturnType Accept<TReturnType>(IOrderVisitor<TReturnType> visitor);
    }
}
