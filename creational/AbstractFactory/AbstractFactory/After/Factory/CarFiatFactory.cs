using AbstractFactory.After.AbstractFactory;
using AbstractFactory.Cars;
using AbstractFactory.Enum;

namespace AbstractFactory.After.Factory
{
    public class CarFiatFactory : CarFactory
    {
        public CarFiatFactory(ICountryRulesAbstractFactory countryRulesAbstractFactory) : base(countryRulesAbstractFactory)
        {
        }

        protected override ICar GetCar(Fuel fuel)
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
