namespace Mediator.Before.Components.Inputs
{
    public class Input
    {
        public string Label { get; set; }
        public bool Visible { get; set; }
        public string Value { get; set; }
        public Input(string label, bool visible)
        {
            Label = label;
            Visible = visible;
        }
    }
}
