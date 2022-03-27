using AbstractFactory.Cars;
using AbstractFactory.Enum;

namespace AbstractFactory.Before.Factory
{
    public class CarToyotaFactory : CarFactory
    {
        public CarToyotaFactory(Country country) : base(country)
        {
        }

        protected override ICar GetCar(Fuel fuel)
        {
            switch (fuel)
            {
                case Fuel.Gas:
                    return new CarToyotaGas();
                case Fuel.Electric:
                    return new CarToyotaElectric();
                default:
                    return null;
            }
        }
    }
}
