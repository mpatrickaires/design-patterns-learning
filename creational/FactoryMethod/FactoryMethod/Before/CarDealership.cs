using FactoryMethod.Cars;
using FactoryMethod.Enum;

namespace FactoryMethod.Before
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

        private ICar GetFiatCar(Fuel fuel)
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
