using AbstractFactory.After.AbstractFactory;
using AbstractFactory.Enum;

/*
* Now, with an Abstract Factory being used, the abstract class CarFactory don't need to worry about
* the country from which the order is coming, because the responsibility of doing things based in
* the country is now delegated to the implementations of ICountryRulesAbstractFactory that is
* received in the constructor by dependency injection.
* With the use of this design pattern, if a new country get added in the application, CarFactory
* will remain intact.
*/

namespace AbstractFactory.After
{
    public static class ClientAbstractFactory
    {
        public static void Run()
        {
            var carDealership = new CarDealership();
            var brazilCountryRules = new BrazilRulesAbstractFactory();
            var unitedStatesCountryRules = new UnitedStatesRulesAbstractFactory();

            Console.WriteLine("== After ==");
            Console.WriteLine();

            Console.WriteLine("--> Getting a Toyota Electric car in Brazil <--");
            Console.WriteLine(carDealership.OrderCar(Manufacturer.Toyota, Fuel.Electric, brazilCountryRules).Details());
            Console.WriteLine();

            Console.WriteLine("--> Getting a Fiat Gas car in United States <--");
            Console.WriteLine(carDealership.OrderCar(Manufacturer.Fiat, Fuel.Gas, unitedStatesCountryRules).Details());
        }
    }
}
