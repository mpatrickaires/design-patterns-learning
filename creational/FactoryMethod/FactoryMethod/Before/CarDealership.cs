using FactoryMethod.Cars;
using FactoryMethod.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Before
{
    /*
     * Without factory, CarDealership needs to have knowledge of all the concrete implementations of 
     * ICar, which creates a high coupling between CarDealership and the concrete classes. 
     * Also, if a new implementation of ICar appears, a new concrete implementation needs to be created 
     * and added to the dependencies of CarDealership
     */
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
