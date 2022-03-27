using FactoryMethod.Cars;

namespace FactoryMethod.After.Complex.Factory
{
    public class CarToyotaGasFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new CarToyotaGas();
        }
    }
}
