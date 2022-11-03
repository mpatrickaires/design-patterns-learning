using Strategy.Before.Enums;
using Strategy.Common.Models.Vehicles;
using Strategy.Common.Models.Vehicles.Interfaces;
using Strategy.Common.Models.Vehicles.Parts.Motors;
using Strategy.Common.Models.Vehicles.Parts.Wheels;

namespace Strategy.Before.Services
{
    public class VehicleFactory
    {
        private readonly VehicleType _vehicleTyple;

        public VehicleFactory(VehicleType vehicleTyple)
        {
            _vehicleTyple = vehicleTyple;
        }

        public IVehicle FabricateVehicle()
        {
            switch (_vehicleTyple)
            {
                case VehicleType.Car:
                    Console.WriteLine("Fabricating a car...");

                    var car = new Car();
                    car.InsertMotor(new CarMotor());
                    car.FillFuel();
                    for (int i = 0; i < 4; i++)
                    {
                        car.InsertWheel(new CarWheel());
                    }

                    return car;
                case VehicleType.Motorcycle:
                    Console.WriteLine("Fabricating a motorcycle...");

                    var motorcycle = new Motorcycle();
                    motorcycle.InsertMotor(new MotorcycleMotor());
                    motorcycle.FillFuel();
                    for (int i = 0; i < 2; i++)
                    {
                        motorcycle.InsertWheel(new MotorcycleWheel());
                    }

                    return motorcycle;
                case VehicleType.Bicycle:
                    Console.WriteLine("Fabricating a bicycle...");

                    var bicycle = new Bicycle();
                    for (int i = 0; i < 2; i++)
                    {
                        bicycle.InsertWheel(new BicycleWheel());
                    }

                    return bicycle;
                default:
                    return null;
            }
        }
    }
}
