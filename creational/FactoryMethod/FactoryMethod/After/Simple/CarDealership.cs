using FactoryMethod.Cars;
using FactoryMethod.Enum;
using FactoryMethod.After.Simple.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.After.Simple
{
    /*
     * Using Simple Factory, we have the same advantages of the Complex and HalfSimple Factory, but now
     * the CarDealership only needs to know one concrete implementation of ICarFactory (if we used
     * Inversion of Control, not even this would be necessary), while all the complexity of creating
     * a new car was also transfered to this factory.
     * Now, no matter how many new cars will be added to the application, the CarDealership or any 
     * other class that may use those cars will not need to be changed due to that, those new cars will
     * only need to be added at the implementation of ICarFactory.
     */

    public class CarDealership
    {
        public ICar OrderCar(Manufacturer manufacturer, Fuel fuel)
        {
            ICarFactory carFactory = new CarFactory();

            return carFactory.CreateCar(manufacturer, fuel);
        }
    }

    /*
     * Example using Inversion of Control through Dependency Injection to achieve the 
     * Dependency Inversion (the CarDealership will not need to instanciate the implementations of
     * ICarFactory, therefore it doesn't need to know who is the concrete implementation of 
     * ICarFactory).
     */

    public class CarDealership_DependencyInjection
    {
        private readonly ICarFactory _carFactory;

        public CarDealership_DependencyInjection(ICarFactory carFactory)
        {
            _carFactory = carFactory;
        }

        public ICar OrderCar(Manufacturer manufacturer, Fuel fuel) => _carFactory.CreateCar(manufacturer, fuel);
    }
}
