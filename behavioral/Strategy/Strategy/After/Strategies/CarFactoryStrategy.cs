using Strategy.After.Strategies.Interfaces;
using Strategy.Common.Models.Vehicles;
using Strategy.Common.Models.Vehicles.Interfaces;
using Strategy.Common.Models.Vehicles.Parts.Motors;
using Strategy.Common.Models.Vehicles.Parts.Wheels;

namespace Strategy.After.Strategies
{
    public class CarFactoryStrategy : IVehicleFactoryStrategy
    {
        public IVehicle FabricateVehicle()
        {
            Console.WriteLine("Fabricating a car...");

            var car = new Car();
            car.InsertMotor(new CarMotor());
            car.FillFuel();
            for (int i = 0; i < 4; i++)
            {
                car.InsertWheel(new CarWheel());
            }

            return car;
        }
    }
}
