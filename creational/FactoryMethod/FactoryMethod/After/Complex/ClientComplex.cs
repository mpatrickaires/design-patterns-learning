using FactoryMethod.Enum;

/*
* Using Complex Factory, the CarDealership now doesn't need to know what are the concrete 
* implementations of ICar, but only need the ICarFactory and his concrete implementations.
* The only problem here is that this creates a new coupling between CarDealership and the concrete
* implementations of ICarFactory; also, if a new implementation of ICar appears, a new concrete
* factory needs to be created and added to the dependencies of CarDealership.
*/

namespace FactoryMethod.After.Complex
{
    public static class ClientComplex
    {
        public static void Run()
        {
            var carDealership = new CarDealership();

            Console.WriteLine("== After - Complex ==");
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
