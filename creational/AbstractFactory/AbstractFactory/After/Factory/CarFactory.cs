using AbstractFactory.Enum;
using AbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.After.Models.Invoice;
using AbstractFactory.After.Models.LicensePlate;
using AbstractFactory.After.AbstractFactory;

namespace AbstractFactory.After.Factory
{
    /*
    * Now, with an Abstract Factory being used, the abstract class CarFactory don't need to worry about
    * the country from which the order is coming, because the responsibility of doing things based in
    * the country is now delegated to the implementations of ICountryRulesAbstractFactory that is
    * received in the constructor by dependency injection.
    * With the use of this design pattern, if a new country get added in the application, CarFactory
    * will remain intact.
    */
    public abstract class CarFactory
    {
        private readonly ICountryRulesAbstractFactory _countryRulesAbstractFactory;

        protected CarFactory(ICountryRulesAbstractFactory countryRulesAbstractFactory)
        {
            _countryRulesAbstractFactory = countryRulesAbstractFactory;
        }

        public ICar CreateCar(Fuel fuel)
        {
            var car = GetCar(fuel);

            _countryRulesAbstractFactory.CreateInvoice().PrintInvoice();
            _countryRulesAbstractFactory.CreateLicensePlate().InstallLicensePlate();

            return car;
        }

        protected abstract ICar GetCar(Fuel fuel);
    }
}
