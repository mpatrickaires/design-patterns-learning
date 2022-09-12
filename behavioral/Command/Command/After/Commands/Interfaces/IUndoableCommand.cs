namespace Command.After.Commands.Interfaces
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
    }
}
