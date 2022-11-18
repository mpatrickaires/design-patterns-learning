namespace Visitor.Before.Models.Orders.Interfaces
{
    public interface IOrder
    {
        string Taker { get; }
        decimal Price { get; }
        decimal Tax { get; set; }
    }
}
