using AbstractFactory.Before.Factory;
using AbstractFactory.Cars;
using AbstractFactory.Enum;

namespace AbstractFactory.Before
{
    public class CarDealership
    {
        public ICar OrderCar(Manufacturer manufacturer, Fuel fuel, Country country)
        {
            switch (manufacturer)
            {
                case Manufacturer.Toyota:
                    return new CarToyotaFactory(country).CreateCar(fuel);
                case Manufacturer.Fiat:
                    return new CarFiatFactory(country).CreateCar(fuel);
                default:
                    return null;
            }
        }
    }
}
