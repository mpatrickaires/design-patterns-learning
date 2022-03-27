using FactoryMethod.Cars;
using FactoryMethod.Enum;

namespace FactoryMethod.After.HalfSimple.Factory
{
    public class CarToyotaFactory : ICarFactory
    {
        public ICar CreateCar(Fuel fuel)
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
