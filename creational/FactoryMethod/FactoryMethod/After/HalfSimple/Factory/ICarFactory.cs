using FactoryMethod.Enum;
using FactoryMethod.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.After.HalfSimple.Factory
{
    public interface ICarFactory
    {
        ICar CreateCar(Fuel fuel);
    }
}
