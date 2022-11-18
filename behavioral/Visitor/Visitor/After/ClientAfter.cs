using Visitor.After.Models;
using Visitor.After.Models.Orders.Interfaces;
using Visitor.After.Services;
using Visitor.Common;
using Visitor.Common.Data;

/*
 * [Author's note: 
 * Before going any further, I think it is important to discuss how the Visitor patterns differentiate itself from the
 * Strategy pattern, since they can be seen as being very similar and thus cause some conffusion to those learning. 
 * From my understanding: 
 * - The Strategy pattern has an family of alghoritms, each with a different behavior, and my objective is to apply 
 *   those behaviors dinamically to a single class, being kind of a one-to-many relationship (one class with multiple
 *   behaviors).
 * - The Visitor pattern has a group of related classes and also a family of alghoritms with different behaviors that 
 *   are defined by which class it is dealing with, being kind of a many-to-many relatioship (multiple classes with
 *   multiple behaviors).
 * This is obviously a very simplified point of view, but from my studies this is how I see each one and how I would
 * make a decision of which one to apply.] 
 * 
 * So, let's understand what is happening!
 * Well, the main idea is to have the classes that works and depends on the orders (that is, the tax calculation class
 * and the invoice generator class) to take advantage of the polymorphism and then have multiples methods sharing the 
 * same name but having a difference in the signature, which is the order class that it will work with; they are called 
 * the visitors, and implements an interface/abstract class which already have all these methods.
 * This is just the beginning of the fun! Having that created, we will make all our order classes implement a method
 * which will take as argument the visitor interface implemented by classes such as the tax calculator and the invoice 
 * generator (working with the interface here allows the order classes to take any visitor while being decoupled from 
 * its concrete implementation). With that, all that the class taking the visitor needs to do is call its method which
 * takes the concrete class, passing itself as argument; this takes greatly advantage of the polymorphism and helps to 
 * disappear with many 'ifs' simply by passing the responsibility of which method to call to the concrete class (in this 
 * pattern, it is common that the visitor's method is named 'Visit', while the method of the class that calls it and
 * pass itself as an argument is named 'Accept'; this is how we named it in our example).
 * 
 * However, for this pattern, there is a very clearly downside to keep in mind: in our example, for each new order class
 * that may appear, it will be necessary to include in the visitor class a method to work with this new order class,
 * havin to reflect it to all our concrete visitors.
 */

namespace Visitor.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("===> After <===");

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
            Console.WriteLine(productPurchaseOrder.Accept(invoiceGenerator));
            Console.WriteLine();
            Console.WriteLine("Shipping Order Invoice:");
            Console.WriteLine(shippingOrder.Accept(invoiceGenerator));
            Console.WriteLine();
            Console.WriteLine("Service Order Invoice:");
            Console.WriteLine(serviceOrder.Accept(invoiceGenerator));
        }

        private static void SetOrdersTax(params IOrder[] orders)
        {
            var taxCalculator = new OrderTaxCalculator();
            foreach (var order in orders) order.Tax = order.Accept(taxCalculator);
        }
    }
}
