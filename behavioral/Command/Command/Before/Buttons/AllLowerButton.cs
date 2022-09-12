using Command.Common;

namespace Command.Before.Buttons
{
    public class AllLowerButton : TextEditorButton
    {
        public AllLowerButton(string caption, TextEditor textEditor) : base(caption, textEditor)
        {
        }

        public override void Click()
        {
            TextEditor.Text = TextEditor.Text.ToLower();
        }
    }
}
