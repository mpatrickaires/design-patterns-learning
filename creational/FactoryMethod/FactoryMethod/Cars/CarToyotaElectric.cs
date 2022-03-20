using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Cars
{
    public class CarToyotaElectric : ICar
    {
        public string Details()
        {
            return "Toyota Electric Car";
        }
    }
}
