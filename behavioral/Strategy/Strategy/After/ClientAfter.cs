using Strategy.After.Services;
using Strategy.After.Strategies;

/*
 * Now, this is the usage of the Strategy pattern, so let's understand it.
 * Firstly, we extracted the different behaviours of each condition statement into their own classes.
 * For example, the routine of fabricating a car, a motorcycle and a bicycle is now extracted into a
 * class, which represent the strategy. Now, for the VehicleFactory class (which in the strategy pattern
 * would be refered as the context class), it doens't need to have the multiple conditions statements
 * for the type of the vehicle anymore, the only things it needs is to reference the strategy for the 
 * necessary behavior. The context class (VehicleFactory) will communicate with the strategy only 
 * through the interface, which allows the strategy to be defined at runtime.
 * In all that, the client will then define which strategy it wants the context class to execute (the
 * client needs to have knowledge of the objective of each strategy), which can be done by Dependency 
 * Injection.
 * So that's it, by doing this implementation, when the fabrication of a new vehicle becomes necessary,
 * we will not need to modify the VehicleFactory class, just by creating a new strategy class and 
 * including it for the client to inject, we will already easily include this new behavior.
 */

namespace Strategy.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("== After ==");

            var carFactory = new VehicleFactory(new CarFactoryStrategy());
            var car = carFactory.FabricateVehicle();
            car.Drive();
            Console.WriteLine();

            var motorcycleFactory = new VehicleFactory(new MotorcycleFactoryStrategy());
            var motorcycle = motorcycleFactory.FabricateVehicle();
            motorcycle.Drive();
            Console.WriteLine();

            var bicycleFactory = new VehicleFactory(new BicycleFactoryStrategy());
            var bicycle = bicycleFactory.FabricateVehicle();
            bicycle.Drive();
            Console.WriteLine();
        }
    }
}
