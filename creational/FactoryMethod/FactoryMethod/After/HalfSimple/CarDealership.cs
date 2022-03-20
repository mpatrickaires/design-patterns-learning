using FactoryMethod.Cars;
using FactoryMethod.Enum;
using FactoryMethod.After.HalfSimple.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.After.HalfSimple
{
    /*
     * Using HalfSimple Factory, we have the same advantages of the Complex Factory, with the 
     * difference that now the concrete implementations of ICarFactory are grouped by the manufacturer
     * (CarToyotaFactory for Toyota cars and CarFiatFactory for Fiat cars), with the only variation 
     * being the Fuel. This helps in reducing the coupling and achieve a better maintainability 
     * of the code. But still, if a new manufacturer is created, the concrete implementations of this
     * new factory needs to be added to CarDealership.
     * It's also good to observe that using the HalfSimple Factory, the complexity of the code in the
     * functions GetToyotaCar and GetFiatCar was greatly reduced, considering that the creation based
     * in the fuel was delegated to the factories.
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
