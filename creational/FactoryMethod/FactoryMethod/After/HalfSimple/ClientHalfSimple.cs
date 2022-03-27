using FactoryMethod.Enum;

/*
* Using HalfSimple Factory, we have the same advantages of the Complex Factory, with the 
* difference that now the concrete implementations of ICarFactory are grouped by the manufacturer
* (CarToyotaFactory for Toyota cars and CarFiatFactory for Fiat cars), with the only variation 
* being the Fuel. This helps in reducing the coupling and achieve a better maintainability 
* of the code. But still, if a new manufacturer is created, the concrete implementations of this
* new factory needs to be added to CarDealership.
* It's also good to observe that using the HalfSimple Factory, the complexity of the code in the
* functions GetToyotaCar and GetFiatCar was greatly reduced, considering that the creation based
* in the fuel was delegated to the factories.
*/

namespace FactoryMethod.After.HalfSimple
{
    public static class ClientHalfSimple
    {
        public static void Run()
        {
            var carDealership = new CarDealership();

            Console.WriteLine("== After - HalfSimple ==");
            Console.WriteLine();

            Console.WriteLine("--> Getting a Toyota Electric car <--");
            Console.WriteLine(carDealership.OrderCar(Manufacturer.Toyota, Fuel.Electric).Details());
            Console.WriteLine();

            Console.WriteLine("--> Getting a Fiat Gas car <--");
            Console.WriteLine(carDealership.OrderCar(Manufacturer.Fiat, Fuel.Gas).Details());
            Console.WriteLine();
        }
    }
}
