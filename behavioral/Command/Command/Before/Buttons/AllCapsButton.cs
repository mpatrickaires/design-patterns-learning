using Command.Common;

namespace Command.Before.Buttons
{
    public class AllCapsButton : TextEditorButton
    {
        public AllCapsButton(string caption, TextEditor textEditor) : base(caption, textEditor)
        {
        }

        public override void Click()
        {
            TextEditor.Text = TextEditor.Text.ToUpper();
        }
    }
}
