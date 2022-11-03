using Strategy.Before.Enums;
using Strategy.Before.Services;

/*
 * Let's say we have an application that is able to fabricate vehicles (wow, pretty advanced, uh?) through a factory service. Its capabilities
 * is to fabricate cars, motorcycles and bicycles, and it takes the decision to which one is going to be fabricated by an enum that defines the
 * type of the vehicle.
 * Well, each vehicle has its particularities in the fabrication process, for example:
 * - A car needs a motor, four wheels and fuel.
 * - A motorcycle needs a motor, two wheels and fuel.
 * - A bicycle only needs two wheels.
 * This is where the problem resides, because each fabrication takes different paths and we would need
 * to throw different conditions for that in the code; this would quickly create a boilerplate code,
 * where if we wanted to add the fabrication of a new vehicle, we would need to change the existing 
 * class and with it have the risk of breaking the code for the other fabrications.
 * 
 * We can see that it would quickly become a problem and create a big difficulty for extending the code,
 * while breaking the Open Closed Principle.
 * With that in mind, let's take a look at how we can use the Strategy pattern to solve this situation.
 */

namespace Strategy.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            var carFactory = new VehicleFactory(VehicleType.Car);
            var car = carFactory.FabricateVehicle();
            car.Drive();
            Console.WriteLine();

            var motorcycleFactory = new VehicleFactory(VehicleType.Motorcycle);
            var motorcycle = motorcycleFactory.FabricateVehicle();
            motorcycle.Drive();
            Console.WriteLine();

            var bicycleFactory = new VehicleFactory(VehicleType.Bicycle);
            var bicycle = bicycleFactory.FabricateVehicle();
            bicycle.Drive();
            Console.WriteLine();
        }
    }
}
