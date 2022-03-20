using AbstractFactory.Enum;
using AbstractFactory.After.AbstractFactory;

static void Separate()
{
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine();
}

/*
 * Executing Before abstract factory implementation
 */
var carDealershipBefore = new AbstractFactory.Before.CarDealership();

Console.WriteLine(">> Before <<");
Console.WriteLine();

Console.WriteLine("== Getting a Toyota Electric car in Brazil ==");
Console.WriteLine(carDealershipBefore.OrderCar(Manufacturer.Toyota, Fuel.Electric, Country.Brazil).Details());
Console.WriteLine();

Console.WriteLine("== Getting a Fiat Gas car in United States ==");
Console.WriteLine(carDealershipBefore.OrderCar(Manufacturer.Fiat, Fuel.Gas, Country.UnitedStates).Details());
Console.WriteLine();

Separate();

/*
 * Executing After abstract factory implementation
 */
var carDealershipAfter = new AbstractFactory.After.CarDealership();
var brazilCountryRules = new BrazilRulesAbstractFactory();
var unitedStatesCountryRules = new UnitedStatesRulesAbstractFactory();

Console.WriteLine(">> After <<");
Console.WriteLine();

Console.WriteLine("== Getting a Toyota Electric car in Brazil ==");
Console.WriteLine(carDealershipAfter.OrderCar(Manufacturer.Toyota, Fuel.Electric, brazilCountryRules).Details());
Console.WriteLine();

Console.WriteLine("== Getting a Fiat Gas car in United States ==");
Console.WriteLine(carDealershipAfter.OrderCar(Manufacturer.Fiat, Fuel.Gas, unitedStatesCountryRules).Details());
