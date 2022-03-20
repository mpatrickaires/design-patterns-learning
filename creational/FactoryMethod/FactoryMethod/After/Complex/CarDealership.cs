using FactoryMethod.Cars;
using FactoryMethod.Enum;
using FactoryMethod.After.Complex.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.After.Complex
{
    /*
     * Using Complex Factory, the CarDealership now doesn't need to know what are the concrete 
     * implementations of ICar, but only need the ICarFactory and his concrete implementations.
     * The only problem here is that this creates a new coupling between CarDealership and the concrete
     * implementations of ICarFactory; also, if a new implementation of ICar appears, a new concrete
     * factory needs to be created and added to the dependencies of CarDealership.
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
            ICarFactory carToyotaGasFactory = new CarToyotaGasFactory();
            ICarFactory carToyotaElectricFactory = new CarToyotaElectricFactory();

            switch (fuel)
            {
                case Fuel.Gas:
                    return carToyotaGasFactory.CreateCar();
                case Fuel.Electric:
                    return carToyotaElectricFactory.CreateCar();
                default:
                    return null;
            }
        }

        private ICar GetFiatCar(Fuel fuel)
        {
            ICarFactory carFiatGasFactory = new CarFiatGasFactory();
            ICarFactory carFiatElectricFactory = new CarFiatElectricFactory();

            switch (fuel)
            {
                case Fuel.Gas:
                    return carFiatGasFactory.CreateCar();
                case Fuel.Electric:
                    return carFiatElectricFactory.CreateCar();
                default:
                    return null;
            }
        }
    }
}
