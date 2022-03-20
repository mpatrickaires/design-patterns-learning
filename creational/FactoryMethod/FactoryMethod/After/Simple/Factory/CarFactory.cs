using FactoryMethod.Cars;
using FactoryMethod.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.After.Simple.Factory
{
    public class CarFactory : ICarFactory
    {
        public ICar CreateCar(Manufacturer manufacturer, Fuel fuel)
        {
            switch (manufacturer)
            {
                case Manufacturer.Toyota:
                    return CreateToyotaCar(fuel);
                case Manufacturer.Fiat:
                    return CreateFiatCar(fuel);
                default:
                    return null;
            }
        }

        protected ICar CreateToyotaCar(Fuel fuel)
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

        protected ICar CreateFiatCar(Fuel fuel)
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
