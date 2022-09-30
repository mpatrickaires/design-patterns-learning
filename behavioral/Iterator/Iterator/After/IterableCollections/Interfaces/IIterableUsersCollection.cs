using Iterator.After.Iterators.Interfaces;

namespace Iterator.After.IterableCollections.Interfaces
{
    public interface IIterableUsersCollection
    {
        IUsersIterator CreateIterator();
    }
}
