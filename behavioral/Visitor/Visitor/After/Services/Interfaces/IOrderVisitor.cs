using Visitor.After.Models;

namespace Visitor.After.Services.Interfaces
{
    public interface IOrderVisitor<TReturnType>
    {
        TReturnType Visit(ProductPurchaseOrder order);
        TReturnType Visit(ShippingOrder order);
        TReturnType Visit(ServiceOrder order);
    }
}
