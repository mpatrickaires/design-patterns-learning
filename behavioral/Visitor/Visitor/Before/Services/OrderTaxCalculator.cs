using Visitor.Before.Models;
using Visitor.Before.Models.Orders.Interfaces;
using Visitor.Common;

namespace Visitor.Before.Services
{
    public class OrderTaxCalculator
    {
        public decimal Calculate(IOrder order)
        {
            if (order is ProductPurchaseOrder purchaseOrder)
            {
                decimal tax = 0m;
                foreach (var product in purchaseOrder.Products)
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
            if (order is ShippingOrder shippingOrder)
            {
                if (shippingOrder.Weight < 1000) return shippingOrder.Price;
                if (shippingOrder.Weight < 2000) return shippingOrder.Price * 0.5m;
                if (shippingOrder.Weight < 10000) return shippingOrder.Price * 0.15m;
                return shippingOrder.Price * 0.20m;
            }
            if (order is ServiceOrder serviceOrder)
            {
                return serviceOrder.Price * 0.15m;
            }
            throw new NotImplementedException(nameof(order));
        }

        public decimal Calculate(ProductPurchaseOrder order)
        {
            decimal tax = 0m;
            foreach (var product in order.Products)
            {
                tax += product.Category switch
                {
                    ProductCategory.Clothing => product.Price * 0.05m,
                    ProductCategory.Electronics => product.Price * 0.15m,
                    ProductCategory.Medicine => 0m,
                    _ => throw new ArgumentOutOfRangeException(nameof(order.Products)),
                };
            }
            return tax;
        }

        public decimal Calculate(ShippingOrder order)
        {
            if (order.Weight < 1000) return order.Price;
            if (order.Weight < 2000) return order.Price * 0.5m;
            if (order.Weight < 10000) return order.Price * 0.15m;
            return order.Price * 0.20m;
        }

        public decimal Calculate(ServiceOrder order)
        {
            return order.Price * 0.15m;
        }
    }
}
