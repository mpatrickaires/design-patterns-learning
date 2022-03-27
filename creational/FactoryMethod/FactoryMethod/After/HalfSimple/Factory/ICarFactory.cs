using FactoryMethod.Cars;
using FactoryMethod.Enum;

namespace FactoryMethod.After.HalfSimple.Factory
{
    public interface ICarFactory
    {
        ICar CreateCar(Fuel fuel);
    }
}
