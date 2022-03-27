using FactoryMethod.Enum;

/*
* Using Simple Factory, we have the same advantages of the Complex and HalfSimple Factory, but now
* the CarDealership only needs to know one concrete implementation of ICarFactory (if we used
* Inversion of Control, not even this would be necessary), while all the complexity of creating
* a new car was also transfered to this factory.
* Now, no matter how many new cars will be added to the application, the CarDealership or any 
* other class that may use those cars will not need to be changed due to that, those new cars will
* only need to be added at the implementation of ICarFactory.
*/

namespace FactoryMethod.After.Simple
{
    public static class ClientSimple
    {
        public static void Run()
        {
            var carDealership = new CarDealership();

            Console.WriteLine("== After - Simple ==");
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
