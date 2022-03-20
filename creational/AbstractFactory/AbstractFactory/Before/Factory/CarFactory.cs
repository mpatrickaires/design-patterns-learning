using AbstractFactory.Enum;
using AbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Before.Models.Invoice;
using AbstractFactory.Before.Models.LicensePlate;

namespace AbstractFactory.Before.Factory
{
    /*
    * While creating a Car, the CarFactory needs to print an invoice and install the license plate (this
    * is valid due to factories being able to hold logic involved in the creation of an object).
    * However, without an Abstract Factory, the abstract class CarFactory will need to have a specific 
    * implementation for each country inside his constructor (or, in the case of interface, the  
    * classes will have to do it always). This leaves an extreme verbose code and, if a new Country get 
    * added to the application, this class will suffer alterations because of that.
    */
    public abstract class CarFactory
    {
        private readonly IInvoice _invoice;
        private readonly ILicensePlate _licensePlate;
        public CarFactory(Country country)
        {
            switch (country)
            {
                case Country.Brazil:
                    _invoice = new BrazilInvoice();
                    _licensePlate = new BrazilLicensePlate();
                    break;
                case Country.UnitedStates:
                    _invoice = new UnitedStatesInvoice();
                    _licensePlate = new UnitedStatesLicensePlate();
                    break;
                default:
                    throw new ArgumentException("Invalid country!");
            }
        }

        public ICar CreateCar(Fuel fuel)
        {
            var car = GetCar(fuel);

            _invoice.PrintInvoice();
            _licensePlate.InstallLicensePlate();

            return car;
        }

        protected abstract ICar GetCar(Fuel fuel);
    }
}
