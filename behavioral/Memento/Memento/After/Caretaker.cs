using TextEditorMemento = Memento.After.TextEditor.TextEditorMemento;

namespace Memento.After
{
    public class Caretaker
    {
        private Stack<TextEditorMemento> _mementos = new();

        public void Add(TextEditorMemento memento) => _mementos.Push(memento);

        public void Restore()
        {
            if (!_mementos.TryPop(out var memento)) return;

            memento.Restore();
        }
    }
}
