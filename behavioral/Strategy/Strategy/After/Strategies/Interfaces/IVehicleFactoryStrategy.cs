using Strategy.Common.Models.Vehicles.Interfaces;

namespace Strategy.After.Strategies.Interfaces
{
    public interface IVehicleFactoryStrategy
    {
        IVehicle FabricateVehicle();
    }
}
