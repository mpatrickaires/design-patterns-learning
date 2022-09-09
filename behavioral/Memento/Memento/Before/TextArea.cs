namespace Memento.Before
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
    }
}
