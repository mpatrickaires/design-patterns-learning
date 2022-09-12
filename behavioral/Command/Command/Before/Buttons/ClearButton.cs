using Command.Common;

namespace Command.Before.Buttons
{
    public class ClearButton : TextEditorButton
    {
        public ClearButton(string caption, TextEditor textEditor) : base(caption, textEditor)
        {
        }

        public override void Click()
        {
            TextEditor.Clear();
        }
    }
}
