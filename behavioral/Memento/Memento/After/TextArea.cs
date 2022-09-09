namespace Memento.After
{
    public class TextEditor
    {
        public string Text { get; set; }
        private string _internalId;

        public void WriteText(string text)
        {
            Text = text;
            _internalId = Guid.NewGuid().ToString().Substring(0, 8);

            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Text: {Text} \nInternal ID: {_internalId}\n";
        }

        public TextEditorMemento Save() => new TextEditorMemento(this, Text, _internalId);

        public class TextEditorMemento
        {
            private readonly TextEditor _textEditor;
            private readonly string _text;
            private readonly string _internalId;

            public TextEditorMemento(TextEditor textEditor, string text, string internalId)
            {
                _textEditor = textEditor;
                _text = text;
                _internalId = internalId;
            }

            public void Restore()
            {
                _textEditor.Text = _text;
                _textEditor._internalId = _internalId;
            }
        }
    }
}
