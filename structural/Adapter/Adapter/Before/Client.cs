using Adapter.Models;

/*
 * Without the Adapter, when we have a class that requires an object that implements an abstraction
 * that is incompatible with what we actually have, we will be incapable of using that class without 
 * making some messy code by changing the inner code of the class we actually have.
 * Or it could even be worse, because the incompatible class may originate from some third-party 
 * library. In this case, making changes in this incompatible class could generate errors or may even 
 * be impossible due to the inner code not being visible for us.
 */

namespace Adapter.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            var xmlData = UsDollarExchangeProvider.GetDollarExchange();

            /* 
             * We can't use the class CurrencyExchangeDisplay because it requires an object that 
             * implements the interface IJsonData, being incompatible with the object we are 
             * using (xmlData), since it implements a different interface (IXmlData).
             */
            // var display = new CurrencyExchangeDisplay("US Dollar", xmlData);

            Console.WriteLine("--> Currency Exchange Data (XML) <--");
            Console.WriteLine(xmlData.GetXmlData());
            Console.WriteLine();

            Console.WriteLine("--> Currency Exchange Display <--");
            Console.WriteLine("Oops... We can't do that without the Adapter!");
        }
    }
}
