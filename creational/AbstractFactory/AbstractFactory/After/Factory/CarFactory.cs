using AbstractFactory.After.AbstractFactory;
using AbstractFactory.Cars;
using AbstractFactory.Enum;

namespace AbstractFactory.After.Factory
{
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
