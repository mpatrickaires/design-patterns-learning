using FactoryMethod.Cars;

namespace FactoryMethod.After.Complex.Factory
{
    public class CarToyotaElectricFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new CarToyotaElectric();
        }
    }
}
