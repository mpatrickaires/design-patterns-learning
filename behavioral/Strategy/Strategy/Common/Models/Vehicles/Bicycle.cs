using Strategy.Common.Models.Vehicles.Interfaces;
using Strategy.Common.Models.Vehicles.Parts.Wheels;

namespace Strategy.Common.Models.Vehicles
{
    public class Bicycle : IVehicle
    {
        private readonly IList<BicycleWheel> _wheels = new List<BicycleWheel>();

        public void Drive()
        {
            if (_wheels.Count != 2) throw new InvalidOperationException("A bicycle needs two wheels to move!");

            Console.WriteLine("Driving a bicycle.");
        }

        public void InsertWheel(BicycleWheel wheel)
        {
            if (_wheels.Count >= 2) throw new InvalidOperationException("A bicycle can only have two wheels!");
            _wheels.Add(wheel);
        }
    }
}
