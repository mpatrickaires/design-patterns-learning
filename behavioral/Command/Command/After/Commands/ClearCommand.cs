using Command.Common;

namespace Command.After.Commands
{
    public class ClearCommand : BaseTextEditorCommand
    {
        public ClearCommand(TextEditor textEditor) : base(textEditor)
        {
        }

        public override void Execute()
        {
            Backup = TextEditor.Text;
            TextEditor.Clear();
        }
    }
}
