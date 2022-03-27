using AbstractFactory.Before.Models.Invoice;
using AbstractFactory.Before.Models.LicensePlate;
using AbstractFactory.Cars;
using AbstractFactory.Enum;

namespace AbstractFactory.Before.Factory
{
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
