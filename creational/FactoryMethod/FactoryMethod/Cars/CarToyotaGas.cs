using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Cars
{
    public class CarToyotaGas : ICar
    {
        public string Details()
        {
            return "Toyota Gas Car";
        }
    }
}
