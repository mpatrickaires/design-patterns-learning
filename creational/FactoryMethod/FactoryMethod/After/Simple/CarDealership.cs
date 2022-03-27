using FactoryMethod.After.Simple.Factory;
using FactoryMethod.Cars;
using FactoryMethod.Enum;

namespace FactoryMethod.After.Simple
{
    public class CarDealership
    {
        public ICar OrderCar(Manufacturer manufacturer, Fuel fuel)
        {
            ICarFactory carFactory = new CarFactory();

            return carFactory.CreateCar(manufacturer, fuel);
        }
    }

    /*
     * Example using Inversion of Control through Dependency Injection to achieve the 
     * Dependency Inversion (the CarDealership will not need to instanciate the implementations of
     * ICarFactory, therefore it doesn't need to know who is the concrete implementation of 
     * ICarFactory).
     */

    public class CarDealership_DependencyInjection
    {
        private readonly ICarFactory _carFactory;

        public CarDealership_DependencyInjection(ICarFactory carFactory)
        {
            _carFactory = carFactory;
        }

        public ICar OrderCar(Manufacturer manufacturer, Fuel fuel) => _carFactory.CreateCar(manufacturer, fuel);
    }
}
