using Adapter.After.ClassAdapter.Adapters;
using Adapter.Models;
using Adapter.Services;

/*
 * By using the Class Adapter, we are using the Adapter pattern in a way where the adapter will be the
 * actual object to handle the calls without the need to wrap the object that is needed to be adapted
 * because the adapter class actually inherits from him, which will make him be able to call the
 * necessary methods by himself.
 */

namespace Adapter.After.ClassAdapter
{
    public static class ClientClassAdapter
    {
        public static void Run()
        {
            Console.WriteLine("== After - Class Adapter ==");

            var xmlData = UsDollarExchangeProvider.GetDollarExchange();

            XmlDataToJsonDataAdapter adapter = new XmlDataToJsonDataAdapter(xmlData.GetXmlData());

            var display = new CurrencyExchangeDisplay("US Dollar", adapter);

            Console.WriteLine("--> Currency Exchange Data (XML) <--");
            Console.WriteLine(adapter.GetXmlData());
            Console.WriteLine();

            Console.WriteLine("--> Currency Exchange Display <--");
            display.DisplayData();
        }
    }
}
