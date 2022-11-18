using System.Xml.Linq;
using Visitor.After.Models;
using Visitor.After.Services.Interfaces;

namespace Visitor.After.Services
{
    public class OrderInvoiceGenerator : IOrderVisitor<string>
    {
        public string Visit(ProductPurchaseOrder order)
        {
            var products = order.Products.Select(p =>
                                new XElement("product",
                                    new XElement("name", p.Name),
                                    new XElement("price", p.Price),
                                    new XElement("category", p.Category))).ToArray();

            return
                new XElement("purchaseOrder",
                    new XElement("taker", order.Taker),
                    new XElement("products", products),
                    new XElement("productTax", order.Tax)).ToString();
        }

        public string Visit(ShippingOrder order)
        {
            var products = order.Products.Select(p =>
                                new XElement("product",
                                    new XElement("name", p.Name),
                                    new XElement("price", p.Price),
                                    new XElement("weight", new XAttribute("unit", "grams"), p.Weight))).ToArray();

            return
                new XElement("shippingOrder",
                    new XElement("taker", order.Taker),
                    new XElement("products", products),
                    new XElement("weight", new XAttribute("unit", "grams"), order.Weight),
                    new XElement("price", order.Price),
                    new XElement("shippingType", order.ShippingType),
                    new XElement("shippingTax", order.Tax)).ToString();
        }

        public string Visit(ServiceOrder order)
        {
            return
                new XElement("serviceOrder",
                    new XElement("taker", order.Taker),
                    new XElement("description", order.Description),
                    new XElement("price", order.Price),
                    new XElement("serviceTax", order.Tax)).ToString();
        }
    }
}
