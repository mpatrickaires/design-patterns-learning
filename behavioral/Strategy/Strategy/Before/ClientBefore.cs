using Strategy.Before.Enums;
using Strategy.Before.Services;

/*
 * Let's say we have an application that is able to fabricate vehicles (wow, pretty advanced, uh?) through a factory service. Its capabilities
 * is to fabricate cars, motorcycles and bicycles, and it takes the decision to which one is going to be fabricated by an enum that defines the
 * type of the vehicle.
 * Well, each vehicle has its particularities in the fabrication process.
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
