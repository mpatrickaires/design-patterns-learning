using Strategy.After.Strategies.Interfaces;
using Strategy.Common.Models.Vehicles;
using Strategy.Common.Models.Vehicles.Interfaces;
using Strategy.Common.Models.Vehicles.Parts.Motors;
using Strategy.Common.Models.Vehicles.Parts.Wheels;

namespace Strategy.After.Strategies
{
    public class MotorcycleFactoryStrategy : IVehicleFactoryStrategy
    {
        public IVehicle FabricateVehicle()
        {
            Console.WriteLine("Fabricating a motorcycle...");

            var motorcycle = new Motorcycle();
            motorcycle.InsertMotor(new MotorcycleMotor());
            motorcycle.FillFuel();
            for (int i = 0; i < 2; i++)
            {
                motorcycle.InsertWheel(new MotorcycleWheel());
            }

            return motorcycle;
        }
    }
}
