using Strategy.After.Strategies.Interfaces;
using Strategy.Common.Models.Vehicles;
using Strategy.Common.Models.Vehicles.Interfaces;
using Strategy.Common.Models.Vehicles.Parts.Wheels;

namespace Strategy.After.Strategies
{
    public class BicycleFactoryStrategy : IVehicleFactoryStrategy
    {
        public IVehicle FabricateVehicle()
        {
            Console.WriteLine("Fabricating a bicycle...");

            var bicycle = new Bicycle();
            for (int i = 0; i < 2; i++)
            {
                bicycle.InsertWheel(new BicycleWheel());
            }

            return bicycle;
        }
    }
}
