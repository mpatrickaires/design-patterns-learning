using FactoryMethod.Cars;
using FactoryMethod.Enum;

namespace FactoryMethod.After.Simple.Factory
{
    public interface ICarFactory
    {
        ICar CreateCar(Manufacturer manufacturer, Fuel fuel);
    }
}
