using Iterator.Model;

namespace Iterator.After.Iterators.Interfaces
{
    public interface IUsersIterator
    {
        User Current();
        User Next();
        bool IsDone();

    }
}
