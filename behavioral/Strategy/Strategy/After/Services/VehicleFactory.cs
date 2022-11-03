using Strategy.After.Strategies.Interfaces;
using Strategy.Common.Models.Vehicles.Interfaces;

namespace Strategy.After.Services
{
    public class VehicleFactory
    {
        private readonly IVehicleFactoryStrategy _strategy;

        public VehicleFactory(IVehicleFactoryStrategy strategy)
        {
            _strategy = strategy;
        }

        public IVehicle FabricateVehicle() => _strategy.FabricateVehicle();
    }
}
