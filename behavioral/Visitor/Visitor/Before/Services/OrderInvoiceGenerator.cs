using System.Xml.Linq;
using Visitor.Before.Models;
using Visitor.Before.Models.Orders.Interfaces;

namespace Visitor.Before.Services
{
    public class OrderInvoiceGenerator
    {
        public string Generate(IOrder order)
        {
            if (order is ProductPurchaseOrder purchaseOrder)
            {
                var products = purchaseOrder.Products.Select(p =>
                    new XElement("product",
                        new XElement("name", p.Name),
                        new XElement("price", p.Price),
                        new XElement("category", p.Category))).ToArray();

                return
                    new XElement("purchaseOrder",
                        new XElement("taker", purchaseOrder.Taker),
                        new XElement("products", products),
                        new XElement("productTax", purchaseOrder.Tax)).ToString();
            }
            if (order is ShippingOrder shippingOrder)
            {
                var products = shippingOrder.Products.Select(p =>
                    new XElement("product",
                        new XElement("name", p.Name),
                        new XElement("price", p.Price),
                        new XElement("weight", new XAttribute("unit", "grams"), p.Weight))).ToArray();

                return
                    new XElement("shippingOrder",
                        new XElement("taker", shippingOrder.Taker),
                        new XElement("products", products),
                        new XElement("weight", new XAttribute("unit", "grams"), shippingOrder.Weight),
                        new XElement("price", shippingOrder.Price),
                        new XElement("shippingType", shippingOrder.ShippingType),
                        new XElement("shippingTax", shippingOrder.Tax)).ToString();
            }
            if (order is ServiceOrder serviceOrder)
            {
                return
                    new XElement("serviceOrder",
                        new XElement("taker", serviceOrder.Taker),
                        new XElement("description", serviceOrder.Description),
                        new XElement("price", serviceOrder.Price),
                        new XElement("serviceTax", serviceOrder.Tax)).ToString();
            }
            throw new NotImplementedException(nameof(order));
        }
    }
}
