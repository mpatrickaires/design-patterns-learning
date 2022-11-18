using Visitor.Before.Models;
using Visitor.Before.Models.Orders.Interfaces;
using Visitor.Before.Services;
using Visitor.Common;
using Visitor.Common.Data;

/*
 * Alright, so let's imagine the following: you have a program that is able to generate orders for products purchase,
 * shipping and services. For those orders, it is necessary to do some business logic to calculate the tax and also to
 * generate an invoice. So far so great, right?
 * Well, there is the bitter part: for each order, there are different logics to calculate tax and to generate invoice.
 * Because of that, your classes that perform those operations needs to work with multiple 'ifs' and casting to perform
 * the correct operations when receiveing an interface that represents an order. This is a problem, because if there
 * is the need to add the generation of a new order to the program, you will need to modify the internal structure of
 * the classes that calculate tax and generate invoice by adding a new 'if' and casting, which would violate the 
 * Open Closed Principle.
 * 
 * With that in mind, let's take a look at how the Visitor pattern can help us to achieve a better code.
 */

namespace Visitor.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("===> Before <===");

            var products = ProductsFactory.GenerateProductsCollection();

            var productPurchaseOrder = new ProductPurchaseOrder("Walter White", products);
            var shippingOrder = new ShippingOrder("Dor Draper", 30m, ShippingType.Interstate, products);
            var serviceOrder = new ServiceOrder("Anakin Skywalker", "Lightsaber Polishing", 150m);

            var invoiceGenerator = new OrderInvoiceGenerator();

            SetOrdersTax(productPurchaseOrder, shippingOrder, serviceOrder);

            Console.WriteLine($"Product Purchase Order Tax: US$ {productPurchaseOrder.Tax}");
            Console.WriteLine($"Shipping Order Tax: US$ {shippingOrder.Tax}");
            Console.WriteLine($"Service Order Tax: US$ {serviceOrder.Tax}");

            Console.WriteLine();

            Console.WriteLine("Product Purchase Order Invoice:");
            Console.WriteLine(invoiceGenerator.Generate(productPurchaseOrder));
            Console.WriteLine();
            Console.WriteLine("Shipping Order Invoice:");
            Console.WriteLine(invoiceGenerator.Generate(shippingOrder));
            Console.WriteLine();
            Console.WriteLine("Service Order Invoice:");
            Console.WriteLine(invoiceGenerator.Generate(serviceOrder));
        }

        private static void SetOrdersTax(params IOrder[] orders)
        {
            var taxCalculator = new OrderTaxCalculator();
            foreach (var order in orders) order.Tax = taxCalculator.Calculate(order);
        }
    }
}