using FactoryMethod.Cars;

namespace FactoryMethod.After.Complex.Factory
{
    public class CarFiatElectricFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new CarFiatElectric();
        }
    }
}
