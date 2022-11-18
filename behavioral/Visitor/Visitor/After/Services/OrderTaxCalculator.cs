using Visitor.After.Models;
using Visitor.After.Services.Interfaces;
using Visitor.Common;

namespace Visitor.After.Services
{
    public class OrderTaxCalculator : IOrderVisitor<decimal>
    {
        public decimal Visit(ProductPurchaseOrder order)
        {
            decimal tax = 0m;
            foreach (var product in order.Products)
            {
                tax += product.Category switch
                {
                    ProductCategory.Clothing => product.Price * 0.05m,
                    ProductCategory.Electronics => product.Price * 0.15m,
                    ProductCategory.Medicine => 0m,
                    _ => throw new ArgumentOutOfRangeException(nameof(order)),
                };
            }
            return tax;
        }

        public decimal Visit(ShippingOrder order)
        {
            if (order.Weight < 1000) return order.Price;
            if (order.Weight < 2000) return order.Price * 0.5m;
            if (order.Weight < 10000) return order.Price * 0.15m;
            return order.Price * 0.20m;
        }

        public decimal Visit(ServiceOrder order)
        {
            return order.Price * 0.15m;
        }
    }
}
