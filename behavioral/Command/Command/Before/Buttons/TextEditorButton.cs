using Command.Common;

namespace Command.Before.Buttons
{
    public abstract class TextEditorButton : BaseButton
    {
        protected TextEditor TextEditor;
        public TextEditorButton(string caption, TextEditor textEditor) : base(caption)
        {
            TextEditor = textEditor;
        }
    }
}
