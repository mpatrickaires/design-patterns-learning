using FactoryMethod.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.After.Complex.Factory
{
    public class CarToyotaGasFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new CarToyotaGas();
        }
    }
}
