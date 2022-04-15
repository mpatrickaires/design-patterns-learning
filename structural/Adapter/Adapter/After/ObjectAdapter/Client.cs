using Adapter.After.ObjectAdapter.Adapters;
using Adapter.Models;
using Adapter.Services;

/*
 * Now, using the Adapter pattern, we created a class that has the responsability of making the 
 * necessary adaptations to the object of IXmlData be used by the CurrencyExchangeDisplay (that expects
 * to receive an object that implements the IJsonData). To achieve that, the class that is the adapter
 * (XmlDataToJsonDataAdapter) is the one who implements IJsonData and is given as an argument. 
 * From there, the adapter will take the calls that is made to the IJsonData interface and make the 
 * necessary changes to make the communication between the classes happens (in our example, the adapter 
 * converts the data from XML to JSON string).
 * This is the Object Adapter type because we actually creates an object of the adapter that is 
 * implementing by itself the necessary interface.
 */

namespace Adapter.After.ObjectAdapter
{
    public static class ClientObjectAdapter
    {
        public static void Run()
        {
            Console.WriteLine("== After - Object Adapter ==");

            var xmlData = UsDollarExchangeProvider.GetDollarExchange();

            var adapter = new XmlDataToJsonDataAdapter(xmlData);

            /*
             * We now pass the object of the adapter to the class that is incompatible with our 
             * original object. This will work because the class of the adapter implements the 
             * abstraction that is expected.
             */
            var display = new CurrencyExchangeDisplay("US Dollar", adapter);

            Console.WriteLine("--> Currency Exchange Data (XML) <--");
            Console.WriteLine(xmlData.GetXmlData());
            Console.WriteLine();

            Console.WriteLine("--> Currency Exchange Display <--");
            display.DisplayData();
        }
    }
}
