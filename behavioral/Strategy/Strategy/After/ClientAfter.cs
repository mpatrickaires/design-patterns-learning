using Strategy.After.Services;
using Strategy.After.Strategies;

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
