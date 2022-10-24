namespace Mediator.After.Components.Checkboxes
{
    public class Checkbox : BaseComponent
    {
        private bool _value;
        public string Label { get; set; }
        public void Check()
        {
            _value = !_value;
            Notify();
        }
        public bool Checked() => _value;
    }
}
