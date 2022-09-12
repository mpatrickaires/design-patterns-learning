using Command.Common;

namespace Command.After.Commands
{
    public class AllCapsCommand : BaseTextEditorCommand
    {
        public AllCapsCommand(TextEditor textEditor) : base(textEditor)
        {
        }

        public override void Execute()
        {
            Backup = TextEditor.Text;
            TextEditor.Text = TextEditor.Text.ToUpper();
        }
    }
}
