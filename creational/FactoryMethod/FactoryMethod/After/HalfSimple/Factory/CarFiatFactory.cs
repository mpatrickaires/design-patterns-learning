using FactoryMethod.Cars;
using FactoryMethod.Enum;

namespace FactoryMethod.After.HalfSimple.Factory
{
    public class CarFactory : ICarFactory
    {
        public ICar CreateCar(Fuel fuel)
        {
            switch (fuel)
            {
                case Fuel.Gas:
                    return new CarFiatGas();
                case Fuel.Electric:
                    return new CarFiatElectric();
                default:
                    return null;
            }
        }
    }
}
