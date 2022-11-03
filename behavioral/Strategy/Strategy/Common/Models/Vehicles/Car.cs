using Strategy.Common.Models.Vehicles.Interfaces;
using Strategy.Common.Models.Vehicles.Parts.Motors;
using Strategy.Common.Models.Vehicles.Parts.Wheels;

namespace Strategy.Common.Models.Vehicles
{
    public class Car : IVehicle
    {
        private CarMotor _motor;
        private readonly IList<CarWheel> _wheels = new List<CarWheel>();
        private bool _hasFuel;

        public void Drive()
        {
            if (_motor == null) throw new InvalidOperationException("A car needs a motor to move!");
            if (_wheels.Count != 4) throw new InvalidOperationException("A car needs four wheels to move!");
            if (!_hasFuel) throw new InvalidOperationException("A car needs fuel to move!");

            Console.WriteLine("Driving a car.");
        }

        public void InsertMotor(CarMotor motor) => _motor = motor;

        public void InsertWheel(CarWheel wheel)
        {
            if (_wheels.Count >= 4) throw new InvalidOperationException("A car can only have four wheels!");
            _wheels.Add(wheel);
        }

        public void FillFuel() => _hasFuel = true;

    }
}
