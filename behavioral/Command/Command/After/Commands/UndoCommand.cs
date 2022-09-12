using Command.After.Commands.Interfaces;

namespace Command.After.Commands
{
    public class UndoCommand : ICommand
    {
        private readonly Stack<IUndoableCommand> _commandsHistory;

        public UndoCommand(Stack<IUndoableCommand> commandsHistory)
        {
            _commandsHistory = commandsHistory;
        }

        public void Execute()
        {
            var command = _commandsHistory.Pop();
            command.Undo();
        }
    }
}
