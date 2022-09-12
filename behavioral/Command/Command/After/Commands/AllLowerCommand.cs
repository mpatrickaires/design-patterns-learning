using Command.Common;

namespace Command.After.Commands
{
    public class AllLowerCommand : BaseTextEditorCommand
    {
        public AllLowerCommand(TextEditor textEditor) : base(textEditor)
        {
        }

        public override void Execute()
        {
            Backup = TextEditor.Text;
            TextEditor.Text = TextEditor.Text.ToUpper();
        }
    }
}
