using Strategy.Common.Models.Vehicles.Interfaces;
using Strategy.Common.Models.Vehicles.Parts.Motors;
using Strategy.Common.Models.Vehicles.Parts.Wheels;

namespace Strategy.Common.Models.Vehicles
{
    public class Motorcycle : IVehicle
    {
        private MotorcycleMotor _motor;
        private readonly IList<MotorcycleWheel> _wheels = new List<MotorcycleWheel>();
        private bool _hasFuel;

        public void Drive()
        {
            if (_motor == null) throw new InvalidOperationException("A motorcycle needs a motor to move!");
            if (_wheels.Count != 2) throw new InvalidOperationException("A motorcycle needs two wheels to move!");
            if (!_hasFuel) throw new InvalidOperationException("A motorcycle needs fuel to move!");

            Console.WriteLine("Driving a motorcycle.");
        }

        public void InsertMotor(MotorcycleMotor motor) => _motor = motor;

        public void InsertWheel(MotorcycleWheel wheel)
        {
            if (_wheels.Count >= 2) throw new InvalidOperationException("A motorcycle can only have two wheels!");
            _wheels.Add(wheel);
        }

        public void FillFuel() => _hasFuel = true;
    }
}
