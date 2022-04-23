namespace Composite.After.Models.Interfaces
{
    public interface ISystemObject
    {
        string Name { get; set; }
        int GetTotalSize();
    }
}
