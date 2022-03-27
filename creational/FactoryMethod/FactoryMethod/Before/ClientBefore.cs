using FactoryMethod.Enum;

/*
* Without factory, CarDealership needs to have knowledge of all the concrete implementations of 
* ICar, which creates a high coupling between CarDealership and the concrete classes. 
* Also, if a new implementation of ICar appears, a new concrete implementation needs to be created 
* and added to the dependencies of CarDealership
*/

namespace FactoryMethod.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            var carDealership = new CarDealership();

            Console.WriteLine("== Before ==");
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
