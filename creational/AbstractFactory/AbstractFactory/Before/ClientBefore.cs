using AbstractFactory.Enum;

/*
* While creating a Car, the CarFactory needs to print an invoice and install the license plate (this
* is valid due to factories being able to hold logic involved in the creation of an object).
* However, without an Abstract Factory, the abstract class CarFactory will need to have a specific 
* implementation for each country inside his constructor (or, in the case of interface, the  
* classes will have to do it always). This leaves an extreme verbose code and, if a new Country get 
* added to the application, this class will suffer alterations because of that.
*/

namespace AbstractFactory.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            var carDealership = new CarDealership();

            Console.WriteLine("== Before ==");
            Console.WriteLine();

            Console.WriteLine("--> Getting a Toyota Electric car in Brazil <--");
            Console.WriteLine(carDealership.OrderCar(Manufacturer.Toyota, Fuel.Electric, Country.Brazil).Details());
            Console.WriteLine();

            Console.WriteLine("--> Getting a Fiat Gas car in United States <--");
            Console.WriteLine(carDealership.OrderCar(Manufacturer.Fiat, Fuel.Gas, Country.UnitedStates).Details());
            Console.WriteLine();
        }
    }
}
