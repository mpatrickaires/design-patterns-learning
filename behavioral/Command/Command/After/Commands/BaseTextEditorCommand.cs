using Command.After.Commands.Interfaces;
using Command.Common;

namespace Command.After.Commands
{
    public abstract class BaseTextEditorCommand : IUndoableCommand
    {
        protected TextEditor TextEditor;
        protected string Backup;

        public BaseTextEditorCommand(TextEditor textEditor)
        {
            TextEditor = textEditor;
        }

        public void Undo() => TextEditor.Text = Backup;

        public abstract void Execute();
    }
}
