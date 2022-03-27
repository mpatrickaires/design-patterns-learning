using FactoryMethod.Cars;

namespace FactoryMethod.After.Complex.Factory
{
    public class CarFiatGasFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new CarFiatGas();
        }
    }
}
