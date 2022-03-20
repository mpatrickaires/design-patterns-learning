using AbstractFactory.Enum;
using AbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.After.AbstractFactory;

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
