using FactoryMethod.After.Complex.Factory;
using FactoryMethod.Cars;
using FactoryMethod.Enum;

namespace FactoryMethod.After.Complex
{
    public class CarDealership
    {
        public ICar OrderCar(Manufacturer manufacturer, Fuel fuel)
        {
            switch (manufacturer)
            {
                case Manufacturer.Toyota:
                    return GetToyotaCar(fuel);
                case Manufacturer.Fiat:
                    return GetFiatCar(fuel);
                default:
                    return null;
            }
        }

        private ICar GetToyotaCar(Fuel fuel)
        {
            ICarFactory carToyotaGasFactory = new CarToyotaGasFactory();
            ICarFactory carToyotaElectricFactory = new CarToyotaElectricFactory();

            switch (fuel)
            {
                case Fuel.Gas:
                    return carToyotaGasFactory.CreateCar();
                case Fuel.Electric:
                    return carToyotaElectricFactory.CreateCar();
                default:
                    return null;
            }
        }

        private ICar GetFiatCar(Fuel fuel)
        {
            ICarFactory carFiatGasFactory = new CarFiatGasFactory();
            ICarFactory carFiatElectricFactory = new CarFiatElectricFactory();

            switch (fuel)
            {
                case Fuel.Gas:
                    return carFiatGasFactory.CreateCar();
                case Fuel.Electric:
                    return carFiatElectricFactory.CreateCar();
                default:
                    return null;
            }
        }
    }
}
