using AbstractFactory.After.AbstractFactory;
using AbstractFactory.After.Factory;
using AbstractFactory.Cars;
using AbstractFactory.Enum;

namespace AbstractFactory.After
{
    public class CarDealership
    {
        public ICar OrderCar(Manufacturer manufacturer, Fuel fuel, ICountryRulesAbstractFactory countryRulesAbstractFactory)
        {
            switch (manufacturer)
            {
                case Manufacturer.Toyota:
                    return new CarToyotaFactory(countryRulesAbstractFactory).CreateCar(fuel);
                case Manufacturer.Fiat:
                    return new CarFiatFactory(countryRulesAbstractFactory).CreateCar(fuel);
                default:
                    return null;
            }
        }
    }
}
