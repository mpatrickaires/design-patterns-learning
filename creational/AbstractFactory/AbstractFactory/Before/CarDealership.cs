using AbstractFactory.Cars;
using AbstractFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Before.Factory;

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
