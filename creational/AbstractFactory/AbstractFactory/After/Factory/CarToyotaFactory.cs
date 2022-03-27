using AbstractFactory.After.AbstractFactory;
using AbstractFactory.Cars;
using AbstractFactory.Enum;

namespace AbstractFactory.After.Factory
{
    public class CarToyotaFactory : CarFactory
    {
        public CarToyotaFactory(ICountryRulesAbstractFactory countryRulesAbstractFactory) : base(countryRulesAbstractFactory)
        {
        }

        protected override ICar GetCar(Fuel fuel)
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
    }
}
