﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Cars
{
    public class CarFiatElectric : ICar
    {
        public string Details()
        {
            return "Fiat Electric Car";
        }
    }
}
