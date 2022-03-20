using FactoryMethod.Enum;

static void Separate()
{
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine();
}

/*
 * Executing Before factory method implementation
 */
var carDealershipBefore = new FactoryMethod.Before.CarDealership();

Console.WriteLine(">> Before <<");
Console.WriteLine();

Console.WriteLine("== Getting a Toyota Electric car ==");
Console.WriteLine(carDealershipBefore.OrderCar(Manufacturer.Toyota, Fuel.Electric).Details());
Console.WriteLine();

Console.WriteLine("== Getting a Fiat Gas car ==");
Console.WriteLine(carDealershipBefore.OrderCar(Manufacturer.Fiat, Fuel.Gas).Details());
Console.WriteLine();

Separate();

/*
 * Executing After - Complex implementation
 */
var carDealershipAfter_Complex = new FactoryMethod.After.Complex.CarDealership();

Console.WriteLine(">> After - Complex <<");
Console.WriteLine();

Console.WriteLine("== Getting a Toyota Electric car ==");
Console.WriteLine(carDealershipAfter_Complex.OrderCar(Manufacturer.Toyota, Fuel.Electric).Details());
Console.WriteLine();

Console.WriteLine("== Getting a Fiat Gas car ==");
Console.WriteLine(carDealershipAfter_Complex.OrderCar(Manufacturer.Fiat, Fuel.Gas).Details());
Console.WriteLine();

Separate();

/*
 * Executing After - HalfSimple implementation
 */
var carDealershipAfter_HalfSimple = new FactoryMethod.After.HalfSimple.CarDealership();

Console.WriteLine(">> After - HalfSimple <<");
Console.WriteLine();

Console.WriteLine("== Getting a Toyota Electric car ==");
Console.WriteLine(carDealershipAfter_HalfSimple.OrderCar(Manufacturer.Toyota, Fuel.Electric).Details());
Console.WriteLine();

Console.WriteLine("== Getting a Fiat Gas car ==");
Console.WriteLine(carDealershipAfter_HalfSimple.OrderCar(Manufacturer.Fiat, Fuel.Gas).Details());
Console.WriteLine();

Separate();

/*
 * Executing After - Simple implementation
 */
var carDealershipAfter_Simple = new FactoryMethod.After.Simple.CarDealership();

Console.WriteLine(">> After - Simple <<");
Console.WriteLine();

Console.WriteLine("== Getting a Toyota Electric car ==");
Console.WriteLine(carDealershipAfter_Simple.OrderCar(Manufacturer.Toyota, Fuel.Electric).Details());
Console.WriteLine();

Console.WriteLine("== Getting a Fiat Gas car ==");
Console.WriteLine(carDealershipAfter_Simple.OrderCar(Manufacturer.Fiat, Fuel.Gas).Details());
Console.WriteLine();

Separate();
