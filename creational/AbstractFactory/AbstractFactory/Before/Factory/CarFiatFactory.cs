﻿using AbstractFactory.Cars;
using AbstractFactory.Enum;

namespace AbstractFactory.Before.Factory
{
    public class CarFiatFactory : CarFactory
    {
        public CarFiatFactory(Country country) : base(country)
        {
        }

        protected override ICar GetCar(Fuel fuel)
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
