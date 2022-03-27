using FactoryMethod.After.HalfSimple.Factory;
using FactoryMethod.Cars;
using FactoryMethod.Enum;

namespace FactoryMethod.After.HalfSimple
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
            ICarFactory carToyotaFactory = new CarToyotaFactory();

            return carToyotaFactory.CreateCar(fuel);
        }

        private ICar GetFiatCar(Fuel fuel)
        {
            ICarFactory carFiatFactory = new CarFactory();

            return carFiatFactory.CreateCar(fuel);
        }
    }
}
